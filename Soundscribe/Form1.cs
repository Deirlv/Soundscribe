using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Media;

namespace Soundscribe
{
    public partial class Form1 : Form
    {

        MediaPlayer player = new MediaPlayer();
        bool isLock = true;
        DateTime todayDate = DateTime.Now;

        int remotePort = 11000;

        IPAddress IPAddress = IPAddress.Parse("192.168.178.34");

        class User
        {
            public int Id { get; set; }

            public string Username { get; set; }

            public string Email { get; set; }

            public string DateOfBirth { get; set; }

            public string Password { get; set; }

            public int IsAdmin { get; set; }
        }

        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            InitializeComponent();
            groupBoxUser.Visible = false;
            //admin groupbox
            registerDate.MaxDate = todayDate;

            //Process.Start("Soundscribe Server.exe");
        }
        private void lock_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox p)
            {
                if (isLock)
                {
                    p.Image = Images.lock_open;
                    isLock = false;
                    if(p.Tag == "l" as object)
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
            User user = new User() { Username = loginUsername.Text, Password = loginPassword.Text};

            UdpClient client = new UdpClient();

            try
            {
                string json = "CUL:" + JsonSerializer.Serialize<User>(user);

                byte[] buff = Encoding.Default.GetBytes(json);

                IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                client.Send(buff, buff.Length, remoteEP);

                byte[] received = client.Receive(ref remoteEP);

                string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                if (dataResponse.StartsWith("UCL"))
                {
                    User currentUser = JsonSerializer.Deserialize<User>(dataResponse.Remove(0, "CUA:".Length));

                    groupBoxLogin.Visible = false;
                    groupBoxRegister.Visible = false;
                    groupBoxUser.Visible = true;

                    labelUsername.Text = currentUser.Username;
                    labelEmail.Text = currentUser.Email;
                    labelDate.Text = currentUser.DateOfBirth;
                }
                else if (dataResponse.StartsWith("ACL"))
                {
                    User currentUser = JsonSerializer.Deserialize<User>(dataResponse.Remove(0, "ACL:".Length));

                    groupBoxLogin.Visible = false;
                    groupBoxRegister.Visible = false;

                }
                else if (dataResponse == "UCNL")
                {
                    MessageBox.Show("Username or password is wrong! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(dataResponse == "UNF")
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(registerUsername.Text == string.Empty || registerEmail.Text == string.Empty || registerPassword.Text == string.Empty)
            {
                MessageBox.Show("Some of the fields are empty. Make sure to fill them all out", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(registerDate.Value < todayDate.AddYears(-10))
            {
                MessageBox.Show("You must be at least 10 years old to sign up in Soundscribe! Ask your parents or caregivers for help", "Minimum age", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Regex regex = new Regex("\"^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,}$\"");
            if(!regex.IsMatch(registerPassword.Text))
            {
                MessageBox.Show("Your password must contain: minimum eight characters, at least one letter, one number and one special character", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            User user = new User() { Username = registerUsername.Text, DateOfBirth = registerDate.Value.ToString(), Email = registerEmail.Text, Password = registerPassword.Text};

            UdpClient client = new UdpClient();

            try
            {
                string json = "CUA:" + JsonSerializer.Serialize<User>(user);

                byte[] buff = Encoding.Default.GetBytes(json);

                IPEndPoint remoteEP = new IPEndPoint(IPAddress, remotePort);

                client.Send(buff, buff.Length, remoteEP);

                byte[] received = client.Receive(ref remoteEP);

                string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                if(dataResponse == "UIA")
                {
                    MessageBox.Show("Your account was successfully created!", "Register is completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(dataResponse == "UINA: USERNAME")
                {
                    MessageBox.Show("There is already an account with such a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(dataResponse == "UINA: EMAIL")
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
            Label label = sender as Label;
            if (label != null)
            {
                label.Left = (ClientSize.Width - label.Size.Width) / 2;
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
