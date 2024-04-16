namespace Soundscribe_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxRegister = new GroupBox();
            registerDate = new DateTimePicker();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            label10 = new Label();
            registerPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label6 = new Label();
            registerEmail = new TextBox();
            registerUsername = new TextBox();
            labelChangeSignIn = new Label();
            label8 = new Label();
            label9 = new Label();
            buttonSignUp = new Button();
            groupBoxLogin = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            loginPassword = new TextBox();
            loginUsername = new TextBox();
            labelChangeSignUp = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            groupBoxAdmin = new GroupBox();
            tabControlAdmin = new TabControl();
            tabAdminTests = new TabPage();
            buttonDeleteTest = new Button();
            buttonCreateTest = new Button();
            tabAdminUsers = new TabPage();
            buttonRefreshUsers = new Button();
            buttonAddUser = new Button();
            dataGridUsers = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnUsername = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            columnDateOfBirth = new DataGridViewTextBoxColumn();
            columnPassword = new DataGridViewTextBoxColumn();
            columnIsAdmin = new DataGridViewTextBoxColumn();
            tabAdminAccount = new TabPage();
            buttonAdminLogOut = new Button();
            adminDate = new Label();
            adminEmail = new Label();
            adminUsername = new Label();
            label12 = new Label();
            pictureBox8 = new PictureBox();
            groupBoxUser = new GroupBox();
            tabControlUser = new TabControl();
            tabTests = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabAccount = new TabPage();
            buttonLogOut = new Button();
            labelEmail = new Label();
            labelDate = new Label();
            labelUsername = new Label();
            profilePicture = new PictureBox();
            tabStatistics = new TabPage();
            maxGrade = new Label();
            minGrade = new Label();
            averageGrade = new Label();
            testsTaken = new Label();
            pictureBox7 = new PictureBox();
            label11 = new Label();
            groupBoxRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxAdmin.SuspendLayout();
            tabControlAdmin.SuspendLayout();
            tabAdminTests.SuspendLayout();
            tabAdminUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            tabAdminAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            groupBoxUser.SuspendLayout();
            tabControlUser.SuspendLayout();
            tabTests.SuspendLayout();
            tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            tabStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // groupBoxRegister
            // 
            groupBoxRegister.Controls.Add(registerDate);
            groupBoxRegister.Controls.Add(pictureBox6);
            groupBoxRegister.Controls.Add(pictureBox5);
            groupBoxRegister.Controls.Add(label7);
            groupBoxRegister.Controls.Add(label10);
            groupBoxRegister.Controls.Add(registerPassword);
            groupBoxRegister.Controls.Add(pictureBox3);
            groupBoxRegister.Controls.Add(pictureBox4);
            groupBoxRegister.Controls.Add(label3);
            groupBoxRegister.Controls.Add(label6);
            groupBoxRegister.Controls.Add(registerEmail);
            groupBoxRegister.Controls.Add(registerUsername);
            groupBoxRegister.Controls.Add(labelChangeSignIn);
            groupBoxRegister.Controls.Add(label8);
            groupBoxRegister.Controls.Add(label9);
            groupBoxRegister.Controls.Add(buttonSignUp);
            groupBoxRegister.Location = new Point(0, -9);
            groupBoxRegister.Margin = new Padding(4, 3, 4, 3);
            groupBoxRegister.Name = "groupBoxRegister";
            groupBoxRegister.Padding = new Padding(4, 3, 4, 3);
            groupBoxRegister.Size = new Size(1233, 692);
            groupBoxRegister.TabIndex = 13;
            groupBoxRegister.TabStop = false;
            // 
            // registerDate
            // 
            registerDate.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerDate.Location = new Point(472, 400);
            registerDate.Margin = new Padding(4, 3, 4, 3);
            registerDate.Name = "registerDate";
            registerDate.Size = new Size(266, 27);
            registerDate.TabIndex = 17;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Images.birthday_icon;
            pictureBox6.Location = new Point(747, 403);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Images.email_icon;
            pictureBox5.Location = new Point(747, 324);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(398, 492);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 13);
            label7.TabIndex = 14;
            label7.Text = "Password:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(385, 408);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 13);
            label10.TabIndex = 13;
            label10.Text = "Date of birth:";
            // 
            // registerPassword
            // 
            registerPassword.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerPassword.Location = new Point(472, 483);
            registerPassword.Margin = new Padding(4, 3, 4, 3);
            registerPassword.Name = "registerPassword";
            registerPassword.PasswordChar = '*';
            registerPassword.Size = new Size(266, 27);
            registerPassword.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Images.lock_close;
            pictureBox3.Location = new Point(747, 486);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += lock_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Images.username_icon;
            pictureBox4.Location = new Point(747, 240);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(421, 329);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 13);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(398, 247);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 13);
            label6.TabIndex = 7;
            label6.Text = "Username:";
            // 
            // registerEmail
            // 
            registerEmail.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerEmail.Location = new Point(472, 322);
            registerEmail.Margin = new Padding(4, 3, 4, 3);
            registerEmail.Name = "registerEmail";
            registerEmail.Size = new Size(266, 27);
            registerEmail.TabIndex = 6;
            // 
            // registerUsername
            // 
            registerUsername.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerUsername.Location = new Point(472, 240);
            registerUsername.Margin = new Padding(4, 3, 4, 3);
            registerUsername.Name = "registerUsername";
            registerUsername.Size = new Size(266, 27);
            registerUsername.TabIndex = 5;
            // 
            // labelChangeSignIn
            // 
            labelChangeSignIn.AutoSize = true;
            labelChangeSignIn.BackColor = SystemColors.Menu;
            labelChangeSignIn.Cursor = Cursors.Hand;
            labelChangeSignIn.Font = new Font("Lato Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelChangeSignIn.ForeColor = Color.RoyalBlue;
            labelChangeSignIn.Location = new Point(676, 155);
            labelChangeSignIn.Margin = new Padding(4, 0, 4, 0);
            labelChangeSignIn.Name = "labelChangeSignIn";
            labelChangeSignIn.Size = new Size(73, 27);
            labelChangeSignIn.TabIndex = 4;
            labelChangeSignIn.Text = "Sign in";
            labelChangeSignIn.Click += labelChangeSignIn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lato Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(433, 155);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(248, 27);
            label8.TabIndex = 3;
            label8.Text = "Already have an account?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lato", 47.99999F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(481, 58);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(237, 77);
            label9.TabIndex = 2;
            label9.Text = "Sign up";
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = SystemColors.ControlDark;
            buttonSignUp.ForeColor = SystemColors.ControlText;
            buttonSignUp.Location = new Point(530, 568);
            buttonSignUp.Margin = new Padding(4, 3, 4, 3);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(148, 39);
            buttonSignUp.TabIndex = 0;
            buttonSignUp.Text = "Sign up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(pictureBox2);
            groupBoxLogin.Controls.Add(pictureBox1);
            groupBoxLogin.Controls.Add(label5);
            groupBoxLogin.Controls.Add(label4);
            groupBoxLogin.Controls.Add(loginPassword);
            groupBoxLogin.Controls.Add(loginUsername);
            groupBoxLogin.Controls.Add(labelChangeSignUp);
            groupBoxLogin.Controls.Add(label2);
            groupBoxLogin.Controls.Add(label1);
            groupBoxLogin.Controls.Add(buttonLogin);
            groupBoxLogin.Location = new Point(0, -8);
            groupBoxLogin.Margin = new Padding(4, 3, 4, 3);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Padding = new Padding(4, 3, 4, 3);
            groupBoxLogin.Size = new Size(1233, 692);
            groupBoxLogin.TabIndex = 0;
            groupBoxLogin.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Images.lock_close;
            pictureBox2.Location = new Point(747, 393);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "l";
            pictureBox2.Click += lock_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Images.username_icon;
            pictureBox1.Location = new Point(747, 309);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(398, 399);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 13);
            label5.TabIndex = 8;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(398, 316);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 13);
            label4.TabIndex = 7;
            label4.Text = "Username:";
            // 
            // loginPassword
            // 
            loginPassword.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginPassword.Location = new Point(472, 391);
            loginPassword.Margin = new Padding(4, 3, 4, 3);
            loginPassword.Name = "loginPassword";
            loginPassword.PasswordChar = '*';
            loginPassword.Size = new Size(266, 27);
            loginPassword.TabIndex = 6;
            // 
            // loginUsername
            // 
            loginUsername.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginUsername.Location = new Point(472, 309);
            loginUsername.Margin = new Padding(4, 3, 4, 3);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(266, 27);
            loginUsername.TabIndex = 5;
            // 
            // labelChangeSignUp
            // 
            labelChangeSignUp.AutoSize = true;
            labelChangeSignUp.BackColor = SystemColors.Menu;
            labelChangeSignUp.Cursor = Cursors.Hand;
            labelChangeSignUp.Font = new Font("Lato Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelChangeSignUp.ForeColor = Color.RoyalBlue;
            labelChangeSignUp.Location = new Point(676, 155);
            labelChangeSignUp.Margin = new Padding(4, 0, 4, 0);
            labelChangeSignUp.Name = "labelChangeSignUp";
            labelChangeSignUp.Size = new Size(80, 27);
            labelChangeSignUp.TabIndex = 4;
            labelChangeSignUp.Text = "Sign up";
            labelChangeSignUp.Click += labelChangeSignUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(419, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(262, 27);
            label2.TabIndex = 3;
            label2.Text = "Don't have an account yet?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 47.99999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(481, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 77);
            label1.TabIndex = 2;
            label1.Text = "Sign in";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ControlDark;
            buttonLogin.ForeColor = SystemColors.ControlText;
            buttonLogin.Location = new Point(530, 546);
            buttonLogin.Margin = new Padding(4, 3, 4, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(148, 39);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Sign in";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // groupBoxAdmin
            // 
            groupBoxAdmin.Controls.Add(tabControlAdmin);
            groupBoxAdmin.Location = new Point(-1, -8);
            groupBoxAdmin.Name = "groupBoxAdmin";
            groupBoxAdmin.Size = new Size(1233, 692);
            groupBoxAdmin.TabIndex = 11;
            groupBoxAdmin.TabStop = false;
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabAdminTests);
            tabControlAdmin.Controls.Add(tabAdminUsers);
            tabControlAdmin.Controls.Add(tabAdminAccount);
            tabControlAdmin.Font = new Font("Lato", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlAdmin.Location = new Point(6, 12);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(1220, 672);
            tabControlAdmin.TabIndex = 0;
            // 
            // tabAdminTests
            // 
            tabAdminTests.Controls.Add(buttonDeleteTest);
            tabAdminTests.Controls.Add(buttonCreateTest);
            tabAdminTests.Location = new Point(4, 25);
            tabAdminTests.Name = "tabAdminTests";
            tabAdminTests.Padding = new Padding(3);
            tabAdminTests.Size = new Size(1212, 643);
            tabAdminTests.TabIndex = 0;
            tabAdminTests.Text = "Test editor";
            tabAdminTests.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTest
            // 
            buttonDeleteTest.Font = new Font("Lato", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteTest.Location = new Point(518, 310);
            buttonDeleteTest.Name = "buttonDeleteTest";
            buttonDeleteTest.Size = new Size(177, 46);
            buttonDeleteTest.TabIndex = 1;
            buttonDeleteTest.Text = "Delete Test";
            buttonDeleteTest.UseVisualStyleBackColor = true;
            buttonDeleteTest.Click += buttonDeleteTest_Click;
            // 
            // buttonCreateTest
            // 
            buttonCreateTest.Font = new Font("Lato", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateTest.Location = new Point(518, 229);
            buttonCreateTest.Name = "buttonCreateTest";
            buttonCreateTest.Size = new Size(177, 46);
            buttonCreateTest.TabIndex = 0;
            buttonCreateTest.Text = "Create Test";
            buttonCreateTest.UseVisualStyleBackColor = true;
            buttonCreateTest.Click += buttonCreateTest_Click;
            // 
            // tabAdminUsers
            // 
            tabAdminUsers.Controls.Add(buttonRefreshUsers);
            tabAdminUsers.Controls.Add(buttonAddUser);
            tabAdminUsers.Controls.Add(dataGridUsers);
            tabAdminUsers.Location = new Point(4, 25);
            tabAdminUsers.Name = "tabAdminUsers";
            tabAdminUsers.Padding = new Padding(3);
            tabAdminUsers.Size = new Size(1212, 643);
            tabAdminUsers.TabIndex = 1;
            tabAdminUsers.Text = "User Editor";
            tabAdminUsers.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshUsers
            // 
            buttonRefreshUsers.Location = new Point(89, 608);
            buttonRefreshUsers.Name = "buttonRefreshUsers";
            buttonRefreshUsers.Size = new Size(75, 23);
            buttonRefreshUsers.TabIndex = 2;
            buttonRefreshUsers.Text = "Refresh";
            buttonRefreshUsers.UseVisualStyleBackColor = true;
            buttonRefreshUsers.Click += buttonRefreshUsers_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(8, 608);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(75, 23);
            buttonAddUser.TabIndex = 1;
            buttonAddUser.Text = "Add user";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // dataGridUsers
            // 
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Columns.AddRange(new DataGridViewColumn[] { columnId, columnUsername, columnEmail, columnDateOfBirth, columnPassword, columnIsAdmin });
            dataGridUsers.Location = new Point(8, 7);
            dataGridUsers.MultiSelect = false;
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.ReadOnly = true;
            dataGridUsers.RowTemplate.Height = 25;
            dataGridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUsers.Size = new Size(1197, 591);
            dataGridUsers.TabIndex = 0;
            dataGridUsers.UserDeletingRow += dataGridUsers_UserDeletingRow;
            // 
            // columnId
            // 
            columnId.HeaderText = "Id";
            columnId.Name = "columnId";
            columnId.ReadOnly = true;
            // 
            // columnUsername
            // 
            columnUsername.HeaderText = "Username";
            columnUsername.Name = "columnUsername";
            columnUsername.ReadOnly = true;
            // 
            // columnEmail
            // 
            columnEmail.HeaderText = "Email";
            columnEmail.Name = "columnEmail";
            columnEmail.ReadOnly = true;
            // 
            // columnDateOfBirth
            // 
            columnDateOfBirth.HeaderText = "DateOfBirth";
            columnDateOfBirth.Name = "columnDateOfBirth";
            columnDateOfBirth.ReadOnly = true;
            // 
            // columnPassword
            // 
            columnPassword.HeaderText = "Password";
            columnPassword.Name = "columnPassword";
            columnPassword.ReadOnly = true;
            // 
            // columnIsAdmin
            // 
            columnIsAdmin.HeaderText = "Is Admin";
            columnIsAdmin.Name = "columnIsAdmin";
            columnIsAdmin.ReadOnly = true;
            // 
            // tabAdminAccount
            // 
            tabAdminAccount.Controls.Add(buttonAdminLogOut);
            tabAdminAccount.Controls.Add(adminDate);
            tabAdminAccount.Controls.Add(adminEmail);
            tabAdminAccount.Controls.Add(adminUsername);
            tabAdminAccount.Controls.Add(label12);
            tabAdminAccount.Controls.Add(pictureBox8);
            tabAdminAccount.Location = new Point(4, 25);
            tabAdminAccount.Name = "tabAdminAccount";
            tabAdminAccount.Padding = new Padding(3);
            tabAdminAccount.Size = new Size(1212, 643);
            tabAdminAccount.TabIndex = 2;
            tabAdminAccount.Text = "Account";
            tabAdminAccount.UseVisualStyleBackColor = true;
            // 
            // buttonAdminLogOut
            // 
            buttonAdminLogOut.Location = new Point(542, 551);
            buttonAdminLogOut.Name = "buttonAdminLogOut";
            buttonAdminLogOut.Size = new Size(106, 38);
            buttonAdminLogOut.TabIndex = 5;
            buttonAdminLogOut.Text = "Log out";
            buttonAdminLogOut.UseVisualStyleBackColor = true;
            buttonAdminLogOut.Click += buttonLogOut_Click;
            // 
            // adminDate
            // 
            adminDate.AutoSize = true;
            adminDate.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            adminDate.Location = new Point(527, 368);
            adminDate.Name = "adminDate";
            adminDate.Size = new Size(58, 25);
            adminDate.TabIndex = 4;
            adminDate.Text = "Date";
            // 
            // adminEmail
            // 
            adminEmail.AutoSize = true;
            adminEmail.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            adminEmail.Location = new Point(527, 332);
            adminEmail.Name = "adminEmail";
            adminEmail.Size = new Size(62, 25);
            adminEmail.TabIndex = 3;
            adminEmail.Text = "Email";
            // 
            // adminUsername
            // 
            adminUsername.AutoSize = true;
            adminUsername.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            adminUsername.Location = new Point(527, 299);
            adminUsername.Name = "adminUsername";
            adminUsername.Size = new Size(106, 25);
            adminUsername.TabIndex = 2;
            adminUsername.Text = "Username";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(527, 266);
            label12.Name = "label12";
            label12.Size = new Size(140, 25);
            label12.TabIndex = 1;
            label12.Text = "Status: Admin";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Images.sample_user_icon;
            pictureBox8.Location = new Point(483, 32);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(237, 217);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // groupBoxUser
            // 
            groupBoxUser.Controls.Add(tabControlUser);
            groupBoxUser.Location = new Point(0, -9);
            groupBoxUser.Margin = new Padding(4, 3, 4, 3);
            groupBoxUser.Name = "groupBoxUser";
            groupBoxUser.Padding = new Padding(4, 3, 4, 3);
            groupBoxUser.Size = new Size(1233, 692);
            groupBoxUser.TabIndex = 11;
            groupBoxUser.TabStop = false;
            // 
            // tabControlUser
            // 
            tabControlUser.Controls.Add(tabTests);
            tabControlUser.Controls.Add(tabAccount);
            tabControlUser.Controls.Add(tabStatistics);
            tabControlUser.Font = new Font("Lato", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlUser.Location = new Point(7, 14);
            tabControlUser.Margin = new Padding(4, 3, 4, 3);
            tabControlUser.Name = "tabControlUser";
            tabControlUser.SelectedIndex = 0;
            tabControlUser.Size = new Size(1219, 672);
            tabControlUser.TabIndex = 0;
            // 
            // tabTests
            // 
            tabTests.Controls.Add(flowLayoutPanel1);
            tabTests.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabTests.Location = new Point(4, 25);
            tabTests.Margin = new Padding(4, 3, 4, 3);
            tabTests.Name = "tabTests";
            tabTests.Padding = new Padding(4, 3, 4, 3);
            tabTests.Size = new Size(1211, 643);
            tabTests.TabIndex = 0;
            tabTests.Text = "Tests";
            tabTests.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(7, 7);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1201, 635);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tabAccount
            // 
            tabAccount.Controls.Add(buttonLogOut);
            tabAccount.Controls.Add(labelEmail);
            tabAccount.Controls.Add(labelDate);
            tabAccount.Controls.Add(labelUsername);
            tabAccount.Controls.Add(profilePicture);
            tabAccount.Font = new Font("Lato", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabAccount.Location = new Point(4, 25);
            tabAccount.Margin = new Padding(4, 3, 4, 3);
            tabAccount.Name = "tabAccount";
            tabAccount.Padding = new Padding(4, 3, 4, 3);
            tabAccount.Size = new Size(1211, 643);
            tabAccount.TabIndex = 1;
            tabAccount.Text = "Account";
            tabAccount.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogOut.Location = new Point(543, 553);
            buttonLogOut.Margin = new Padding(4, 3, 4, 3);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(108, 40);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "Log out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(541, 305);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(47, 19);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(541, 336);
            labelDate.Margin = new Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(97, 19);
            labelDate.TabIndex = 2;
            labelDate.Text = "Date of birth";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(541, 273);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(80, 19);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // profilePicture
            // 
            profilePicture.Image = Images.sample_user_icon;
            profilePicture.Location = new Point(501, 75);
            profilePicture.Margin = new Padding(4, 3, 4, 3);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(192, 175);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 0;
            profilePicture.TabStop = false;
            // 
            // tabStatistics
            // 
            tabStatistics.Controls.Add(maxGrade);
            tabStatistics.Controls.Add(minGrade);
            tabStatistics.Controls.Add(averageGrade);
            tabStatistics.Controls.Add(testsTaken);
            tabStatistics.Controls.Add(pictureBox7);
            tabStatistics.Controls.Add(label11);
            tabStatistics.Location = new Point(4, 25);
            tabStatistics.Name = "tabStatistics";
            tabStatistics.Size = new Size(1211, 643);
            tabStatistics.TabIndex = 2;
            tabStatistics.Text = "Statistics";
            tabStatistics.UseVisualStyleBackColor = true;
            // 
            // maxGrade
            // 
            maxGrade.AutoSize = true;
            maxGrade.Font = new Font("Lato", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            maxGrade.Location = new Point(436, 234);
            maxGrade.Name = "maxGrade";
            maxGrade.Size = new Size(109, 23);
            maxGrade.TabIndex = 5;
            maxGrade.Text = "Max grade: ";
            // 
            // minGrade
            // 
            minGrade.AutoSize = true;
            minGrade.Font = new Font("Lato", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minGrade.Location = new Point(436, 196);
            minGrade.Name = "minGrade";
            minGrade.Size = new Size(105, 23);
            minGrade.TabIndex = 4;
            minGrade.Text = "Min grade: ";
            // 
            // averageGrade
            // 
            averageGrade.AutoSize = true;
            averageGrade.Font = new Font("Lato", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            averageGrade.Location = new Point(436, 157);
            averageGrade.Name = "averageGrade";
            averageGrade.Size = new Size(142, 23);
            averageGrade.TabIndex = 3;
            averageGrade.Text = "Average grade: ";
            // 
            // testsTaken
            // 
            testsTaken.AutoSize = true;
            testsTaken.Font = new Font("Lato", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            testsTaken.Location = new Point(436, 118);
            testsTaken.Name = "testsTaken";
            testsTaken.Size = new Size(112, 23);
            testsTaken.TabIndex = 2;
            testsTaken.Text = "Tests taken: ";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Images.statistics_icon;
            pictureBox7.Location = new Point(805, 64);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(24, 24);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lato", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(404, 59);
            label11.Name = "label11";
            label11.Size = new Size(395, 29);
            label11.TabIndex = 0;
            label11.Text = "Complete statistics for your account:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 685);
            Controls.Add(groupBoxRegister);
            Controls.Add(groupBoxAdmin);
            Controls.Add(groupBoxLogin);
            Controls.Add(groupBoxUser);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Soundscribe";
            groupBoxRegister.ResumeLayout(false);
            groupBoxRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxAdmin.ResumeLayout(false);
            tabControlAdmin.ResumeLayout(false);
            tabAdminTests.ResumeLayout(false);
            tabAdminUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            tabAdminAccount.ResumeLayout(false);
            tabAdminAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            groupBoxUser.ResumeLayout(false);
            tabControlUser.ResumeLayout(false);
            tabTests.ResumeLayout(false);
            tabAccount.ResumeLayout(false);
            tabAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            tabStatistics.ResumeLayout(false);
            tabStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxRegister;
        private System.Windows.Forms.DateTimePicker registerDate;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.Label labelChangeSignIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabTests;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Label labelChangeSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabStatistics;
        private PictureBox pictureBox7;
        private Label label11;
        private Label testsTaken;
        private Label averageGrade;
        private Label minGrade;
        private Label maxGrade;
        private GroupBox groupBoxAdmin;
        private TabControl tabControlAdmin;
        private TabPage tabAdminTests;
        private TabPage tabAdminUsers;
        private Button buttonAddUser;
        private DataGridView dataGridUsers;
        private TabPage tabAdminAccount;
        private Label adminEmail;
        private Label adminUsername;
        private Label label12;
        private PictureBox pictureBox8;
        private Label adminDate;
        private Button buttonAdminLogOut;
        private Button buttonDeleteTest;
        private Button buttonCreateTest;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnUsername;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewTextBoxColumn columnDateOfBirth;
        private DataGridViewTextBoxColumn columnPassword;
        private DataGridViewTextBoxColumn columnIsAdmin;
        private Button buttonRefreshUsers;
    }
}
