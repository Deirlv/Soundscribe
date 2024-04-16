namespace Soundscribe_App
{
    partial class TestCreator
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
            label6 = new Label();
            testName = new TextBox();
            label1 = new Label();
            testDescription = new TextBox();
            flowLayoutPanelTest = new FlowLayoutPanel();
            buttonAddQuestion = new Button();
            buttonDeletePrevious = new Button();
            buttonSubmitTest = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(351, 39);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 13);
            label6.TabIndex = 9;
            label6.Text = "Test name(must be unique):";
            // 
            // testName
            // 
            testName.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            testName.Location = new Point(494, 32);
            testName.Margin = new Padding(4, 3, 4, 3);
            testName.Name = "testName";
            testName.Size = new Size(266, 27);
            testName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(420, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 13);
            label1.TabIndex = 11;
            label1.Text = "Description:";
            // 
            // testDescription
            // 
            testDescription.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            testDescription.Location = new Point(494, 75);
            testDescription.Margin = new Padding(4, 3, 4, 3);
            testDescription.Name = "testDescription";
            testDescription.Size = new Size(266, 27);
            testDescription.TabIndex = 10;
            // 
            // flowLayoutPanelTest
            // 
            flowLayoutPanelTest.AutoScroll = true;
            flowLayoutPanelTest.Location = new Point(39, 127);
            flowLayoutPanelTest.Name = "flowLayoutPanelTest";
            flowLayoutPanelTest.Size = new Size(1156, 470);
            flowLayoutPanelTest.TabIndex = 12;
            // 
            // buttonAddQuestion
            // 
            buttonAddQuestion.Font = new Font("Lato", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddQuestion.Location = new Point(961, 603);
            buttonAddQuestion.Name = "buttonAddQuestion";
            buttonAddQuestion.Size = new Size(234, 36);
            buttonAddQuestion.TabIndex = 13;
            buttonAddQuestion.Text = "Add question";
            buttonAddQuestion.UseVisualStyleBackColor = true;
            buttonAddQuestion.Click += buttonAddQuestion_Click;
            // 
            // buttonDeletePrevious
            // 
            buttonDeletePrevious.Font = new Font("Lato", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeletePrevious.Location = new Point(721, 603);
            buttonDeletePrevious.Name = "buttonDeletePrevious";
            buttonDeletePrevious.Size = new Size(234, 36);
            buttonDeletePrevious.TabIndex = 14;
            buttonDeletePrevious.Text = "Delete previous question";
            buttonDeletePrevious.UseVisualStyleBackColor = true;
            buttonDeletePrevious.Click += buttonDeletePrevious_Click;
            // 
            // buttonSubmitTest
            // 
            buttonSubmitTest.Font = new Font("Lato", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmitTest.Location = new Point(39, 603);
            buttonSubmitTest.Name = "buttonSubmitTest";
            buttonSubmitTest.Size = new Size(234, 36);
            buttonSubmitTest.TabIndex = 15;
            buttonSubmitTest.Text = "Submit test";
            buttonSubmitTest.UseVisualStyleBackColor = true;
            buttonSubmitTest.Click += buttonSubmitTest_Click;
            // 
            // TestCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 685);
            Controls.Add(buttonSubmitTest);
            Controls.Add(buttonDeletePrevious);
            Controls.Add(buttonAddQuestion);
            Controls.Add(flowLayoutPanelTest);
            Controls.Add(label1);
            Controls.Add(testDescription);
            Controls.Add(label6);
            Controls.Add(testName);
            Name = "TestCreator";
            Text = "TestCreator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox testName;
        private Label label1;
        private TextBox testDescription;
        private FlowLayoutPanel flowLayoutPanelTest;
        private Button buttonAddQuestion;
        private Button buttonDeletePrevious;
        private Button buttonSubmitTest;
    }
}