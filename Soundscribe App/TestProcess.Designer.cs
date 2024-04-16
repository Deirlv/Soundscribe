namespace Soundscribe_App
{
    partial class TestProcess
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
            testDescription = new Label();
            testName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // testDescription
            // 
            testDescription.AutoSize = true;
            testDescription.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            testDescription.Location = new Point(12, 41);
            testDescription.Name = "testDescription";
            testDescription.Size = new Size(90, 19);
            testDescription.TabIndex = 1;
            testDescription.Text = "Description";
            // 
            // testName
            // 
            testName.AutoSize = true;
            testName.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            testName.Location = new Point(12, 9);
            testName.Name = "testName";
            testName.Size = new Size(50, 19);
            testName.TabIndex = 0;
            testName.Text = "Name";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 80);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1207, 542);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Lato", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(12, 640);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(130, 33);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit Test";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // TestProcess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 685);
            Controls.Add(buttonSubmit);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(testDescription);
            Controls.Add(testName);
            Name = "TestProcess";
            Text = "Test in process...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label testDescription;
        private Label testName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonSubmit;
    }
}