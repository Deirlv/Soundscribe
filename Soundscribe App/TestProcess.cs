using Soundscribe.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Soundscribe_App
{
    public partial class TestProcess : Form
    {
        IPAddress iPAddress;

        int remotePort;

        User user;

        public Statistic statistic;

        Test test;

        List<TextBox> answers = new List<TextBox>();

        public bool isTestCompleted = false;

        public TestProcess()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            InitializeComponent();
        }

        public TestProcess(User user, Statistic statistic, Test test, IPAddress iP, int port)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.user = user;
            this.statistic = statistic;
            this.test = test;

            iPAddress = iP;
            remotePort = port;

            InitializeComponent();

            BuildTest();

            testName.Text = test.Name;
            testDescription.Text = test.Description;
        }

        void BuildTest()
        {
            foreach (var q in test.Questions!)
            {
                PictureBox templateIcon = new PictureBox();

                templateIcon.Image = Images.sound_icon;
                templateIcon.Location = new Point(490, 37);
                templateIcon.Size = new Size(32, 28);
                templateIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                templateIcon.TabIndex = 0;
                templateIcon.TabStop = false;

                Button templateButtonPlay = new Button();

                templateButtonPlay.Image = Images.play_icon;
                templateButtonPlay.Location = new Point(528, 37);
                templateButtonPlay.Size = new Size(35, 28);
                templateButtonPlay.TabIndex = 1;
                templateButtonPlay.UseVisualStyleBackColor = true;
                templateButtonPlay.Tag = q.QuestionPath;
                templateButtonPlay.Click += TemplateButtonPlay_Click;

                TextBox templateTextBox = new TextBox();

                templateTextBox.Location = new Point(490, 82);
                templateTextBox.Size = new Size(210, 23);
                templateTextBox.TabIndex = 2;

                answers.Add(templateTextBox);

                GroupBox templateGroupBox = new GroupBox();

                templateGroupBox.Controls.Add(templateTextBox);
                templateGroupBox.Controls.Add(templateButtonPlay);
                templateGroupBox.Controls.Add(templateIcon);
                templateGroupBox.Location = new Point(3, 3);
                templateGroupBox.Size = new Size(1200, 153);
                templateGroupBox.TabIndex = 0;
                templateGroupBox.TabStop = false;

                flowLayoutPanel1.Controls.Add(templateGroupBox);
            }
        }

        private async void TemplateButtonPlay_Click(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                SoundPlayer player = new SoundPlayer(Convert.ToString(button.Tag));
                try
                {
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    player.Dispose();
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            foreach (var answer in answers)
            {
                if(answer.Text == string.Empty)
                {
                    MessageBox.Show("Fill all the fields!");
                    return;
                }
            }

            DialogResult d = MessageBox.Show("Are you sure you want to submit your test?", "Test submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(d == DialogResult.No)
            {
                return;
            }

            float notesPerQuestion = 12 / test.Questions!.Count;
            float grade = 0;

            int count = 0;

            for (int i = 0; i < test.Questions!.Count; i++)
            {
                if (answers[i].Text == test.Questions[i].Answer)
                {
                    grade += notesPerQuestion;
                    count++;
                }
            }

            statistic.TestsTaken++;
            statistic.AverageGrade = grade / statistic.TestsTaken;
            if(statistic.MinGrade > grade)
            {
                statistic.MinGrade = grade;
            }
            if (statistic.MaxGrade < grade)
            {
                statistic.MaxGrade = grade;
            }

            UdpClient client = new UdpClient();

            try
            {
                string json = "UUS:" + JsonSerializer.Serialize<Statistic>(statistic);

                byte[] buff = Encoding.Default.GetBytes(json);

                IPEndPoint remoteEP = new IPEndPoint(iPAddress, remotePort);

                client.Send(buff, buff.Length, remoteEP);

                isTestCompleted = true;

                MessageBox.Show($"You have completed the test with {count} out of {test.Questions!.Count}! Your grade is {grade}. With {notesPerQuestion} points per question");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                client.Close();
            }

            Close();
        }
    }
}
