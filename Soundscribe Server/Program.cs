using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Soundscribe.DAL.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Soundscribe.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Soundscribe.DAL.Repositories;
using Soundscribe.DAL.Entities;
using System.Diagnostics;

namespace Soundscribe_Server
{
    internal class Program
    {

        static IPAddress iPAddress = IPAddress.Parse("192.168.178.34");

        static int remotePort = 11000;

        static Service _service;

        public static IHostBuilder Configuration()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    service.AddDbContext<Context>(o =>
                            o.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));

                    service.AddScoped<IRepository, Repository>();
                    service.AddScoped<IService, Service>();
                });
        }

        static async Task Main(string[] args)
        {
            var host = Configuration().Build();

            var context = host.Services.GetRequiredService<Context>();

            _service = new Service(context);

            await Task.Run(async () =>
            {
                UdpClient listener = new UdpClient(new IPEndPoint(iPAddress, remotePort));
                try
                {
                    while (true)
                    {
                        UdpReceiveResult resultReceive = await listener.ReceiveAsync();

                        byte[] buff = resultReceive.Buffer;

                        string receivedData = Encoding.Default.GetString(buff);

                        await Console.Out.WriteLineAsync($"{buff.Length} received from {resultReceive.RemoteEndPoint}");
                        await Console.Out.WriteLineAsync($"Received: {receivedData}");

                        if (receivedData.StartsWith("CUA:"))
                        {
                            receivedData = receivedData.Remove(0, "CUA:".Length);
                            User? user = JsonSerializer.Deserialize<User>(receivedData);

                            string response = string.Empty;

                            UserStatus status = _service.IsUserUnique(user);

                            if (status == UserStatus.Available)
                            {
                                response = "UIA";

                                using (SHA256 sha256Hash = SHA256.Create())
                                {
                                    user.Password = GetHash(sha256Hash, user.Password);
                                }

                                if (!_service.CheckAdmin(user))
                                {
                                    _service.Add(user);
                                    User? userWithID = _service.FindUserByName(user.Username);
                                    Statistic userStatistic = new Statistic() { User = userWithID, UserId = userWithID!.Id, MaxGrade = 0, MinGrade = 0, TestsTaken = 0, AverageGrade = 0 };
                                    _service.Add(userStatistic);
                                }
                                else
                                {
                                    _service.Add(user);
                                }  
                            }
                            else if(status == UserStatus.NotAvailableUsername)
                            {
                                response = "UINA: USERNAME";
                            }
                            else if (status == UserStatus.NotAvailableEmail)
                            {
                                response = "UINA: EMAIL";
                            }

                            byte[] bufferResponse = Encoding.Default.GetBytes(response);

                            await listener.SendAsync(bufferResponse, bufferResponse.Length, resultReceive.RemoteEndPoint);

                            await Console.Out.WriteLineAsync($"{bufferResponse.Length} bytes send to: {resultReceive.RemoteEndPoint}");
                        }
                        else if (receivedData.StartsWith("CUL:"))
                        {
                            receivedData = receivedData.Remove(0, "CUL:".Length);
                            User? user = JsonSerializer.Deserialize<User>(receivedData);

                            User? origUser = _service.FindUserByName(user.Username);

                            string response = string.Empty;

                            if (origUser == null)
                            {
                                response = "UNF";
                            }
                            else
                            {
                                using (SHA256 sha256Hash = SHA256.Create())
                                {
                                    if (origUser.Password == GetHash(sha256Hash, user.Password))
                                    {
                                        if (origUser.IsAdmin == 1)
                                        {
                                            Statistic? userStatistic = _service.GetStatisticByUserID(origUser.Id);

                                            response = "ACL:" + JsonSerializer.Serialize<User>(origUser) + " SFU: " + JsonSerializer.Serialize<Statistic>(userStatistic);
                                        }
                                        else
                                        {
                                            if(origUser.Username.Contains("SFU:"))
                                            {
                                                response = "UCNL";
                                            }
                                            else
                                            {
                                                Statistic? userStatistic = _service.GetStatisticByUserID(origUser.Id);
                                                
                                                response = "UCL:" + JsonSerializer.Serialize<User>(origUser) + " SFU: " + JsonSerializer.Serialize<Statistic>(userStatistic);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        response = "UCNL";
                                    }
                                }
                            }

                            byte[] bufferResponse = Encoding.Default.GetBytes(response);

                            await listener.SendAsync(bufferResponse, bufferResponse.Length, resultReceive.RemoteEndPoint);

                            await Console.Out.WriteLineAsync($"{bufferResponse.Length} bytes send to: {resultReceive.RemoteEndPoint}");
                        }
                        else if (receivedData.StartsWith("GAU"))
                        {
                            string response = JsonSerializer.Serialize<List<User>>(_service.GetAllUsers());

                            byte[] bufferResponse = Encoding.Default.GetBytes(response);

                            await listener.SendAsync(bufferResponse, bufferResponse.Length, resultReceive.RemoteEndPoint);

                            await Console.Out.WriteLineAsync($"{bufferResponse.Length} bytes send to: {resultReceive.RemoteEndPoint}");
                        }
                        else if (receivedData.StartsWith("AU:"))
                        {
                            receivedData = receivedData.Remove(0, "AU:".Length);
                            User? user = JsonSerializer.Deserialize<User>(receivedData);
                            _service.Add(user);
                        }
                        else if (receivedData.StartsWith("DU:"))
                        {
                            receivedData = receivedData.Remove(0, "DU:".Length);
                            User? user = _service.FindUserByName(receivedData);
                            string response = string.Empty;
                            if (user != null)
                            {
                                if (user.IsAdmin == 0)
                                {
                                    Statistic? statistic = _service.GetStatisticByUserID(user.Id);
                                    _service.Remove(statistic!);
                                    _service.Remove(user);
                                    response = "UD";
                                }
                                else
                                {
                                    response = "UND";
                                }

                                byte[] bufferResponse = Encoding.Default.GetBytes(response);

                                await listener.SendAsync(bufferResponse, bufferResponse.Length, resultReceive.RemoteEndPoint);

                                await Console.Out.WriteLineAsync($"{bufferResponse.Length} bytes send to: {resultReceive.RemoteEndPoint}");
                            }
                            else
                            {
                                response = "UND";

                                byte[] bufferResponse = Encoding.Default.GetBytes(response);

                                await listener.SendAsync(bufferResponse, bufferResponse.Length, resultReceive.RemoteEndPoint);

                                await Console.Out.WriteLineAsync($"{bufferResponse.Length} bytes send to: {resultReceive.RemoteEndPoint}");
                            }
                        }
                        else if (receivedData.StartsWith("GAT"))
                        {
                            List<Test> tests = new List<Test>();
                            string response = string.Empty;

                            string testsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tests");

                            if (Directory.Exists(testsDirectory))
                            {
                                string[] testDirectories = Directory.GetDirectories(testsDirectory);

                                foreach (string testDir in testDirectories)
                                {
                                    string jsonDataFile = Path.Combine(testDir, "data.json");

                                    if (File.Exists(jsonDataFile))
                                    {
                                        try
                                        {
                                            string jsonContent = File.ReadAllText(jsonDataFile);

                                            Test test = JsonSerializer.Deserialize<Test>(jsonContent);
                                            if(test != null) 
                                            {
                                                tests.Add(test);
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine($"Error deserializing JSON in {jsonDataFile}: {ex.Message}");
                                        }
                                    }
                                }
                                response = JsonSerializer.Serialize<List<Test>>(tests);
                            }
                            else
                            {
                                response = "TNF";
                            }
                            byte[] bufferResponse = Encoding.Default.GetBytes(response);

                            await listener.SendAsync(bufferResponse, bufferResponse.Length, resultReceive.RemoteEndPoint);

                            await Console.Out.WriteLineAsync($"{bufferResponse.Length} bytes send to: {resultReceive.RemoteEndPoint}");
                        }
                        else if (receivedData.StartsWith("GT:"))
                        {
                            receivedData = receivedData.Remove(0, "GT:".Length);

                            string testsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tests");

                            string response = string.Empty;

                            if (Directory.Exists(testsDirectory))
                            {
                                string testDirectory = Path.Combine(testsDirectory, receivedData);

                                if (Directory.Exists(testDirectory))
                                {
                                    string jsonDataFile = Path.Combine(testDirectory, "data.json");

                                    if (File.Exists(jsonDataFile))
                                    {
                                        try
                                        {
                                            response = File.ReadAllText(jsonDataFile);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                            response = "TNF";
                                        }
                                    }
                                    else
                                    {
                                        response = "TNF";
                                    }
                                }
                                else
                                {
                                    response = "TNF";
                                }
                            }
                            else
                            {
                                response = "TNF";
                            }
                            byte[] bufferResponse = Encoding.Default.GetBytes(response);

                            await listener.SendAsync(bufferResponse, bufferResponse.Length, resultReceive.RemoteEndPoint);

                            await Console.Out.WriteLineAsync($"{bufferResponse.Length} bytes send to: {resultReceive.RemoteEndPoint}");
                        }
                        else if (receivedData.StartsWith("UUS:"))
                        {
                            receivedData = receivedData.Remove(0, "UUS:".Length);
                            Statistic? statistic = JsonSerializer.Deserialize<Statistic>(receivedData);
                            
                            if(statistic != null)
                            {
                                Statistic? currentStatistic = _service.GetStatisticByUserID(statistic.UserId);

                                if(currentStatistic != null)
                                {
                                    currentStatistic.TestsTaken = statistic.TestsTaken;
                                    currentStatistic.AverageGrade = statistic.AverageGrade;
                                    currentStatistic.MinGrade = statistic.MinGrade;
                                    currentStatistic.MaxGrade = statistic.MaxGrade;
                                    _service.Update(currentStatistic);
                                }
                            }
                        }
                        else if (receivedData.StartsWith("CT:"))
                        {
                            receivedData = receivedData.Remove(0, "CT:".Length);

                            Test? test = JsonSerializer.Deserialize<Test>(receivedData);

                            string response = string.Empty;

                            if (test != null)
                            {
                                string folderName = test.Name!;

                                string testsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tests");

                                if (!Directory.Exists(testsFolderPath))
                                {
                                    Directory.CreateDirectory(testsFolderPath);
                                }
                                else
                                {
                                    string folderPath = Path.Combine(testsFolderPath, folderName);
                                    if (Directory.Exists(folderPath))
                                    {
                                        response = "TNC";
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(folderPath);
                                        await Console.Out.WriteLineAsync($"Folder '{folderName}' created in folder 'Tests'.");

                                        response = "TC";

                                        int count = 0;

                                        foreach (var q in test.Questions!)
                                        {
                                            try
                                            {
                                                string targetFilePath = Path.Combine(folderPath, $"{count}.wav");
                                                File.Copy(q.QuestionPath!, targetFilePath);
                                                q.QuestionPath = targetFilePath;
                                            }
                                            catch (Exception ex)
                                            {
                                                response = "TNC";
                                            }
                                            count++;
                                        }
                                        string json = JsonSerializer.Serialize<Test>(test);

                                        using (StreamWriter sw = File.CreateText(Path.Combine(folderPath, "data.json")))
                                        {
                                            sw.WriteLine(json);
                                        }

                                        byte[] bufferResponse = Encoding.Default.GetBytes(response);

                                        await listener.SendAsync(bufferResponse, bufferResponse.Length, resultReceive.RemoteEndPoint);

                                        await Console.Out.WriteLineAsync($"{bufferResponse.Length} bytes send to: {resultReceive.RemoteEndPoint}");
                                    }
                                }
                            }
                        }
                        else if (receivedData.StartsWith("DT:"))
                        {
                            receivedData = receivedData.Remove(0, "DT:".Length);
                        }
                        else
                        {
                            throw new Exception("Server error: Server doesn't understand the received command");
                        }
                    };
                }
                catch (SystemException ex)
                {
                    await Console.Out.WriteLineAsync(ex.Message);
                }

                finally
                {
                    listener.Close();
                }
            });
        }

        static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2")); // Преобразуем каждый байт в шестнадцатеричное представление
            }
            return builder.ToString();
        }
    }
}
