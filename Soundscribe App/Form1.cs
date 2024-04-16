using Soundscribe.DAL.Entities;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Media;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Soundscribe_App
{
    public partial class Form1 : Form
    {
        bool isLock = true;
        DateTime todayDate = DateTime.Now;

        int remotePort = 11000;

        IPAddress IPAddress = IPAddress.Parse("192.168.178.34");

        User? tempUser;

        Statistic? tempStatistic;
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            InitializeComponent();

            groupBoxUser.Visible = false;
            groupBoxAdmin.Visible = false;

            registerDate.MaxDate = todayDate;
        }

        private void lock_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox p)
            {
                if (isLock)
                {
                    p.Image = Images.lock_open;
                    isLock = false;
                    if (p.Tag == "l" as object)
                    {
                        loginPassword.PasswordChar = '\0';
                    }
                    else
                    {
                        registerPassword.PasswordChar = '\0';
                    }
                }
                else
                {
                    p.Image = Images.lock_close;
                    isLock = true;
                    if (p.Tag == "l" as object)
                    {
                        loginPassword.PasswordChar = '*';
                    }
                    else
                    {
                        registerPassword.PasswordChar = '*';
                    }
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = new User() { Username = loginUsername.Text, Password = loginPassword.Text };

            UdpClient client = new UdpClient();

            try
            {

                string json = "CUL:" + JsonSerializer.Serialize<User>(user);

                byte[] buff = Encoding.Default.GetBytes(json);

                IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                client.Send(buff, buff.Length, remoteEP);

                byte[] received = client.Receive(ref remoteEP);

                string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                if (dataResponse.StartsWith("UCL:"))
                {
                    int startIndex = dataResponse.IndexOf("UCL:") + "UCL:".Length;
                    int endIndex = dataResponse.IndexOf("SFU:");

                    string userJson = dataResponse.Substring(startIndex, endIndex - startIndex);
                    string statisticJson = dataResponse.Substring(endIndex + "SFU:".Length);

                    User? currentUser = JsonSerializer.Deserialize<User>(userJson);
                    tempUser = currentUser;
                    Statistic? currentStatistic = JsonSerializer.Deserialize<Statistic>(statisticJson);
                    tempStatistic = currentStatistic;

                    labelUsername.Text = currentUser.Username;
                    labelEmail.Text = currentUser.Email;
                    labelDate.Text = currentUser.DateOfBirth;

                    testsTaken.Text += Convert.ToString(currentStatistic.TestsTaken);
                    averageGrade.Text += Convert.ToString(currentStatistic.AverageGrade);
                    minGrade.Text += Convert.ToString(currentStatistic.MinGrade);
                    maxGrade.Text += Convert.ToString(currentStatistic.MinGrade);

                    LoadTestsInTab();

                    groupBoxLogin.Visible = false;
                    groupBoxRegister.Visible = false;
                    groupBoxUser.Visible = true;
                }
                else if (dataResponse.StartsWith("ACL"))
                {
                    int startIndex = dataResponse.IndexOf("ACL:") + "ACL:".Length;
                    int endIndex = dataResponse.IndexOf("SFU:");

                    string userJson = dataResponse.Substring(startIndex, endIndex - startIndex);
                    string statisticJson = dataResponse.Substring(endIndex + "SFU:".Length);

                    User? currentUser = JsonSerializer.Deserialize<User>(userJson);
                    tempUser = currentUser;
                    Statistic? currentStatistic = JsonSerializer.Deserialize<Statistic>(statisticJson);
                    tempStatistic = currentStatistic;

                    adminUsername.Text = currentUser.Username;
                    adminEmail.Text = currentUser.Email;
                    adminDate.Text = currentUser.DateOfBirth;

                    string query = "GAU";

                    byte[] buffQuery = Encoding.Default.GetBytes(query);

                    client.Send(buffQuery, buffQuery.Length, remoteEP);

                    byte[] buffUsers = client.Receive(ref remoteEP);

                    string jsonUsers = Encoding.Default.GetString(buffUsers, 0, buffUsers.Length);

                    List<User>? users = JsonSerializer.Deserialize<List<User>>(jsonUsers);

                    if (users != null)
                    {
                        foreach (var u in users)
                        {
                            dataGridUsers.Rows.Add(u.Id, u.Username, u.Email, u.DateOfBirth, u.Password, u.IsAdmin);
                        }
                    }

                    groupBoxLogin.Visible = false;
                    groupBoxRegister.Visible = false;
                    groupBoxAdmin.Visible = true;
                }
                else if (dataResponse == "UCNL")
                {
                    MessageBox.Show("Username or password is wrong! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dataResponse == "UNF")
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }

        void LoadTestsInTab()
        {
            UdpClient client = new UdpClient();
            try
            {

                string json = "GAT";

                byte[] buff = Encoding.Default.GetBytes(json);

                IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                client.Send(buff, buff.Length, remoteEP);

                byte[] received = client.Receive(ref remoteEP);

                string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                if (dataResponse.StartsWith("TNF"))
                {
                    MessageBox.Show("Error while loading the tests. Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<Test>? tests = JsonSerializer.Deserialize<List<Test>>(dataResponse);
                    foreach (var test in tests!)
                    {
                        Label templateName = new Label();

                        templateName.AutoSize = true;
                        templateName.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
                        templateName.Location = new Point(17, 38);
                        templateName.Size = new Size(50, 19);
                        templateName.TabIndex = 0;
                        templateName.Text = test.Name;

                        Label templateDescription = new Label();

                        templateDescription.AutoSize = true;
                        templateDescription.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
                        templateDescription.Location = new Point(17, 79);
                        templateDescription.Size = new Size(90, 19);
                        templateDescription.TabIndex = 1;
                        templateDescription.Text = test.Description;

                        Button templateButton = new Button();

                        templateButton.Location = new Point(17, 125);
                        templateButton.Size = new Size(75, 23);
                        templateButton.TabIndex = 2;
                        templateButton.Text = "Take a test";
                        templateButton.UseVisualStyleBackColor = true;
                        templateButton.Tag = test.Name;
                        templateButton.Click += TemplateButton_Click;

                        GroupBox templateGroupBox = new GroupBox();

                        templateGroupBox.Controls.Add(templateButton);
                        templateGroupBox.Controls.Add(templateDescription);
                        templateGroupBox.Controls.Add(templateName);
                        templateGroupBox.Location = new Point(33, 35);
                        templateGroupBox.Size = new Size(1154, 184);
                        templateGroupBox.TabIndex = 0;
                        templateGroupBox.TabStop = false;

                        flowLayoutPanel1.Controls.Add(templateGroupBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }

        private void TemplateButton_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            if (button == null)
            {
                MessageBox.Show("Error while loading the test. Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UdpClient client = new UdpClient();
            try
            {

                string json = $"GT:{button.Tag}";

                byte[] buff = Encoding.Default.GetBytes(json);

                IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                client.Send(buff, buff.Length, remoteEP);

                byte[] received = client.Receive(ref remoteEP);

                string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                if (dataResponse.StartsWith("TNF"))
                {
                    MessageBox.Show("Error while loading the test. Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Test? test = JsonSerializer.Deserialize<Test>(dataResponse);
                    if (test != null)
                    {
                        TestProcess testProcess = new TestProcess(tempUser!, tempStatistic!, test, IPAddress, remotePort);
                        testProcess.ShowDialog();
                        if (testProcess.isTestCompleted)
                        {
                            testsTaken.Text = "Test taken: " + testProcess.statistic.TestsTaken;
                            averageGrade.Text = "Average grade: " + testProcess.statistic.AverageGrade;
                            minGrade.Text = "Min grade: " + testProcess.statistic.MinGrade;
                            maxGrade.Text = "Max grade: " + testProcess.statistic.MaxGrade;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }

        private void labelChangeSignUp_Click(object sender, EventArgs e)
        {
            groupBoxLogin.Visible = false;

            groupBoxRegister.Visible = true;

            loginUsername.Text = string.Empty;
            loginPassword.Text = string.Empty;
        }
        private void labelChangeSignIn_Click(object sender, EventArgs e)
        {
            groupBoxLogin.Visible = true;

            groupBoxRegister.Visible = false;

            registerUsername.Text = string.Empty;
            registerEmail.Text = string.Empty;
            registerDate.Value = todayDate;
            registerPassword.Text = string.Empty;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (registerUsername.Text == string.Empty || registerEmail.Text == string.Empty || registerPassword.Text == string.Empty)
            {
                MessageBox.Show("Some of the fields are empty. Make sure to fill them all out", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            Regex emailRegex = new Regex(emailPattern);

            if (!emailRegex.IsMatch(registerEmail.Text))
            {
                MessageBox.Show("Your email is not in correct format!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DateTime.Today.Year - registerDate.Value.Year < 10)
            {
                MessageBox.Show("You must be at least 10 years old to sign up in Soundscribe! Ask your parents or caregivers for help", "Minimum age", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(registerPassword.Text))
            {
                MessageBox.Show("Your password must contain: minimum eight characters, at least one letter, one number and one special character", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            User user = new User() { Username = registerUsername.Text, DateOfBirth = registerDate.Value.ToShortDateString(), Email = registerEmail.Text, Password = registerPassword.Text };

            UdpClient client = new UdpClient();

            try
            {
                string json = "CUA:" + JsonSerializer.Serialize<User>(user);

                byte[] buff = Encoding.Default.GetBytes(json);

                IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                client.Send(buff, buff.Length, remoteEP);

                byte[] received = client.Receive(ref remoteEP);

                string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                if (dataResponse == "UIA")
                {
                    MessageBox.Show("Your account was successfully created!", "Register is completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dataResponse == "UINA: USERNAME")
                {
                    MessageBox.Show("There is already an account with such a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dataResponse == "UINA: EMAIL")
                {
                    MessageBox.Show("This email was already used! You can only have one account per email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                client.Close();
            }

        }

        private void label_SizeChanged(object sender, EventArgs e)
        {
            Label? label = sender as Label;
            if (label != null)
            {
                label.Left = (ClientSize.Width - label.Size.Width) / 2;
                MessageBox.Show("Size");
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            labelUsername.Text = string.Empty;
            labelEmail.Text = string.Empty;
            labelDate.Text = string.Empty;

            testsTaken.Text = "Test taken: ";
            averageGrade.Text = "Average grade: ";
            minGrade.Text = "Min grade: ";
            maxGrade.Text = "Max grade: ";

            adminUsername.Text = string.Empty;
            adminEmail.Text = string.Empty;
            adminDate.Text = string.Empty;

            groupBoxUser.Visible = false;
            groupBoxAdmin.Visible = false;
            groupBoxLogin.Visible = true;

            tabControlUser.SelectedIndex = 0;

            dataGridUsers.Rows.Clear();

            flowLayoutPanel1.Controls.Clear();

            tempUser = null;
            tempStatistic = null;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            UserEditor userEditor = new UserEditor();
            DialogResult result = userEditor.ShowDialog();

            if (userEditor.isClosedByCode)
            {
                User? user = userEditor.user;
                if (user != null)
                {
                    UdpClient client = new UdpClient();

                    try
                    {
                        string json = "CUA:" + JsonSerializer.Serialize<User>(user);

                        byte[] buff = Encoding.Default.GetBytes(json);

                        IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                        client.Send(buff, buff.Length, remoteEP);

                        byte[] received = client.Receive(ref remoteEP);

                        string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                        if (dataResponse == "UIA")
                        {
                            MessageBox.Show("Your account was successfully created!", "Register is completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (dataResponse == "UINA: USERNAME")
                        {
                            MessageBox.Show("There is already an account with such a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (dataResponse == "UINA: EMAIL")
                        {
                            MessageBox.Show("This email was already used! You can only have one account per email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                    finally
                    {
                        client.Close();
                    }
                }
            }
        }

        private void buttonCreateTest_Click(object sender, EventArgs e)
        {
            TestCreator testCreator = new TestCreator(IPAddress, remotePort);
            testCreator.ShowDialog();
        }

        private void buttonDeleteTest_Click(object sender, EventArgs e)
        {

        }

        private void dataGridUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user All associated statistic will also be deleted", "Deleting User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridUsers.Rows[e.Row.Index];
                string? username = Convert.ToString(row.Cells[1].Value);

                UdpClient client = new UdpClient();

                try
                {
                    string json = "DU:" + username!;

                    byte[] buff = Encoding.Default.GetBytes(json);

                    IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                    client.Send(buff, buff.Length, remoteEP);

                    byte[] received = client.Receive(ref remoteEP);

                    string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                    if (dataResponse == "UD")
                    {
                        dataGridUsers.Rows.RemoveAt(e.Row.Index);
                    }
                    else if (dataResponse == "UND")
                    {
                        MessageBox.Show("Error while deleting user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                finally
                {
                    client.Close();
                }
            }
            e.Cancel = true;
        }

        private void buttonRefreshUsers_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();

            try
            {
                string query = "GAU";

                byte[] buffQuery = Encoding.Default.GetBytes(query);

                IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                client.Send(buffQuery, buffQuery.Length, remoteEP);

                byte[] buffUsers = client.Receive(ref remoteEP);

                string jsonUsers = Encoding.Default.GetString(buffUsers, 0, buffUsers.Length);

                List<User>? users = JsonSerializer.Deserialize<List<User>>(jsonUsers);

                if (users != null)
                {
                    dataGridUsers.Rows.Clear();
                    foreach (var u in users)
                    {
                        dataGridUsers.Rows.Add(u.Id, u.Username, u.Email, u.DateOfBirth, u.Password, u.IsAdmin);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }
    }
}
