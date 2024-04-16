using Soundscribe.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundscribe_App
{
    public partial class UserEditor : Form
    {
        bool isLock = true;

        public bool isClosed { get; set; } = false;

        public bool isClosedByCode { get; set; } = false;

        public User? user;

        public List<User> users;

        public UserEditor()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            InitializeComponent();
            comboBoxAdmin.SelectedIndex = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox p)
            {
                if (isLock)
                {
                    p.Image = Images.lock_open;
                    isLock = false;
                    registerPassword.PasswordChar = '\0';
                }
                else
                {
                    p.Image = Images.lock_close;
                    isLock = true;
                    registerPassword.PasswordChar = '*';
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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

            user = new User() { Username = registerUsername.Text, Email = registerEmail.Text, DateOfBirth = registerDate.Value.ToShortDateString(), Password = registerPassword.Text, IsAdmin = comboBoxAdmin.SelectedIndex };
            isClosedByCode = true;
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosed = true;
        }
    }
}
