namespace Soundscribe_App
{
    partial class UserEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlUserEditor = new TabControl();
            tabUserAdd = new TabPage();
            comboBoxAdmin = new ComboBox();
            label2 = new Label();
            buttonAdd = new Button();
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
            tabControlUserEditor.SuspendLayout();
            tabUserAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tabControlUserEditor
            // 
            tabControlUserEditor.Controls.Add(tabUserAdd);
            tabControlUserEditor.Location = new Point(12, 12);
            tabControlUserEditor.Name = "tabControlUserEditor";
            tabControlUserEditor.SelectedIndex = 0;
            tabControlUserEditor.Size = new Size(776, 426);
            tabControlUserEditor.TabIndex = 1;
            // 
            // tabUserAdd
            // 
            tabUserAdd.Controls.Add(comboBoxAdmin);
            tabUserAdd.Controls.Add(label2);
            tabUserAdd.Controls.Add(buttonAdd);
            tabUserAdd.Controls.Add(registerDate);
            tabUserAdd.Controls.Add(pictureBox6);
            tabUserAdd.Controls.Add(pictureBox5);
            tabUserAdd.Controls.Add(label7);
            tabUserAdd.Controls.Add(label10);
            tabUserAdd.Controls.Add(registerPassword);
            tabUserAdd.Controls.Add(pictureBox3);
            tabUserAdd.Controls.Add(pictureBox4);
            tabUserAdd.Controls.Add(label3);
            tabUserAdd.Controls.Add(label6);
            tabUserAdd.Controls.Add(registerEmail);
            tabUserAdd.Controls.Add(registerUsername);
            tabUserAdd.Location = new Point(4, 24);
            tabUserAdd.Name = "tabUserAdd";
            tabUserAdd.Padding = new Padding(3);
            tabUserAdd.Size = new Size(768, 398);
            tabUserAdd.TabIndex = 0;
            tabUserAdd.Text = "Add user";
            tabUserAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxAdmin
            // 
            comboBoxAdmin.FormattingEnabled = true;
            comboBoxAdmin.Items.AddRange(new object[] { "No", "Yes" });
            comboBoxAdmin.Location = new Point(266, 268);
            comboBoxAdmin.Name = "comboBoxAdmin";
            comboBoxAdmin.Size = new Size(266, 23);
            comboBoxAdmin.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(198, 276);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 13);
            label2.TabIndex = 31;
            label2.Text = "Admin:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(358, 351);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 30;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // registerDate
            // 
            registerDate.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerDate.Location = new Point(266, 147);
            registerDate.Margin = new Padding(4, 3, 4, 3);
            registerDate.Name = "registerDate";
            registerDate.Size = new Size(266, 27);
            registerDate.TabIndex = 29;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Images.birthday_icon;
            pictureBox6.Location = new Point(544, 151);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Images.email_icon;
            pictureBox5.Location = new Point(544, 96);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(195, 217);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 13);
            label7.TabIndex = 26;
            label7.Text = "Password:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(182, 158);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 13);
            label10.TabIndex = 25;
            label10.Text = "Date of birth:";
            // 
            // registerPassword
            // 
            registerPassword.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerPassword.Location = new Point(266, 205);
            registerPassword.Margin = new Padding(4, 3, 4, 3);
            registerPassword.Name = "registerPassword";
            registerPassword.PasswordChar = '*';
            registerPassword.Size = new Size(266, 27);
            registerPassword.TabIndex = 24;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Images.lock_close;
            pictureBox3.Location = new Point(544, 209);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Images.username_icon;
            pictureBox4.Location = new Point(544, 41);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(218, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 13);
            label3.TabIndex = 21;
            label3.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(195, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 13);
            label6.TabIndex = 20;
            label6.Text = "Username:";
            // 
            // registerEmail
            // 
            registerEmail.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerEmail.Location = new Point(266, 93);
            registerEmail.Margin = new Padding(4, 3, 4, 3);
            registerEmail.Name = "registerEmail";
            registerEmail.Size = new Size(266, 27);
            registerEmail.TabIndex = 19;
            // 
            // registerUsername
            // 
            registerUsername.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerUsername.Location = new Point(266, 40);
            registerUsername.Margin = new Padding(4, 3, 4, 3);
            registerUsername.Name = "registerUsername";
            registerUsername.Size = new Size(266, 27);
            registerUsername.TabIndex = 18;
            // 
            // UserEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlUserEditor);
            Name = "UserEditor";
            Text = "UserEditor";
            tabControlUserEditor.ResumeLayout(false);
            tabUserAdd.ResumeLayout(false);
            tabUserAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlUserEditor;
        private TabPage tabUserAdd;
        private ComboBox comboBoxAdmin;
        private Label label2;
        private Button buttonAdd;
        private DateTimePicker registerDate;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label7;
        private Label label10;
        private TextBox registerPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label6;
        private TextBox registerEmail;
        private TextBox registerUsername;
    }
}