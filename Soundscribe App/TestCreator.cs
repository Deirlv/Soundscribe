using Microsoft.VisualBasic.ApplicationServices;
using Soundscribe.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundscribe_App
{
    public partial class TestCreator : Form
    {
        IPAddress iPAddress;

        int remotePort;

        public List<TextBox> Paths = new List<TextBox>();

        public List<TextBox> Answers = new List<TextBox>();

        public Test test = new Test();

        int count = 0;

        public TestCreator()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            InitializeComponent();
        }

        public TestCreator(IPAddress ip, int port)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            iPAddress = ip;
            remotePort = port;
            test.Questions = new List<Question>();

            InitializeComponent();

            AddQuestionToLayout();
        }

        private void AddQuestionToLayout()
        {
            Label templateLabel1 = new Label();

            templateLabel1.AutoSize = true;
            templateLabel1.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            templateLabel1.Location = new Point(404, 108);
            templateLabel1.Size = new Size(66, 19);
            templateLabel1.TabIndex = 3;
            templateLabel1.Text = "Answer:";

            TextBox templateTextBoxAnswer = new TextBox();

            templateTextBoxAnswer.Location = new Point(497, 108);
            templateTextBoxAnswer.Size = new Size(204, 23);
            templateTextBoxAnswer.TabIndex = 2;

            Answers.Add(templateTextBoxAnswer);

            TextBox templateTextBoxFile = new TextBox();

            templateTextBoxFile.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            templateTextBoxFile.Location = new Point(497, 49);
            templateTextBoxFile.ReadOnly = true;
            templateTextBoxFile.Size = new Size(204, 27);
            templateTextBoxFile.TabIndex = 1;

            Paths.Add(templateTextBoxFile);

            Button templateButtonUpload = new Button();

            templateButtonUpload.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            templateButtonUpload.Location = new Point(376, 49);
            templateButtonUpload.Size = new Size(115, 27);
            templateButtonUpload.TabIndex = 0;
            templateButtonUpload.Text = "Upload audio";
            templateButtonUpload.UseVisualStyleBackColor = true;
            templateButtonUpload.Click += fileButton_Click;
            templateButtonUpload.Tag = count;

            GroupBox templateGroupBox = new GroupBox();

            templateGroupBox.Controls.Add(templateLabel1);
            templateGroupBox.Controls.Add(templateTextBoxAnswer);
            templateGroupBox.Controls.Add(templateTextBoxFile);
            templateGroupBox.Controls.Add(templateButtonUpload);
            templateGroupBox.Location = new Point(3, 3);
            templateGroupBox.Name = "groupBoxQuestion";
            templateGroupBox.Size = new Size(1153, 175);
            templateGroupBox.TabIndex = 0;
            templateGroupBox.TabStop = false;

            flowLayoutPanelTest.Controls.Add(templateGroupBox);
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "WAV files (*.wav)|*.wav";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Paths[Convert.ToInt32(button!.Tag)].Text = openFileDialog.FileName;
                }
            }
        }

        private void buttonSubmitTest_Click(object sender, EventArgs e)
        {
            if(testName.Text == string.Empty || testDescription.Text == string.Empty)
            {
                MessageBox.Show("You can't submit test with empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach(var t in Paths) 
            {
                if(t.Text == string.Empty)
                {
                    MessageBox.Show("You can't submit test with empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (var t in Answers)
            {
                if (t.Text == string.Empty)
                {
                    MessageBox.Show("You can't submit test with empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            test.Name = testName.Text;
            test.Description = testDescription.Text;

            for(int i = 0; i < Answers.Count; i++)
            {
                test.Questions.Add(new Question { QuestionPath = Paths[i].Text, Answer = Answers[i].Text });
            }

            UdpClient client = new UdpClient();

            try
            {
                string json = "CT:" + JsonSerializer.Serialize<Test>(test);

                byte[] buff = Encoding.Default.GetBytes(json);

                IPEndPoint remoteEP = new IPEndPoint(iPAddress, remotePort);

                client.Send(buff, buff.Length, remoteEP);

                byte[] received = client.Receive(ref remoteEP);

                string dataResponse = Encoding.Default.GetString(received, 0, received.Length);

                if (dataResponse == "TC")
                {
                    MessageBox.Show("Test was successfully created!", "Test creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dataResponse == "TNC")
                {
                    MessageBox.Show("Error while creating a test. Please, try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
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

        private void buttonDeletePrevious_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                MessageBox.Show("You can't delete the first question!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Paths.RemoveAt(count);
            Answers.RemoveAt(count);
            flowLayoutPanelTest.Controls.RemoveAt(count);
            count--;
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            count++;
            AddQuestionToLayout();
        }
    }
}
