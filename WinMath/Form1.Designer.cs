namespace WinMath
{
    partial class Form1
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
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.howTextBox = new System.Windows.Forms.TextBox();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.nameSubButton = new System.Windows.Forms.Button();
            this.questSubButton = new System.Windows.Forms.Button();
            this.diffSubButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.answerSubButton = new System.Windows.Forms.Button();
            this.questionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(153, 35);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "What is your name?";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Enabled = false;
            this.questionLabel.Location = new System.Drawing.Point(12, 75);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(138, 16);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "How many questions?";
            this.questionLabel.Visible = false;
            // 
            // howTextBox
            // 
            this.howTextBox.Location = new System.Drawing.Point(166, 69);
            this.howTextBox.Name = "howTextBox";
            this.howTextBox.Size = new System.Drawing.Size(100, 22);
            this.howTextBox.TabIndex = 0;
            this.howTextBox.Visible = false;
            this.howTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.howTextBox_KeyPress);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(12, 110);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(216, 16);
            this.difficultyLabel.TabIndex = 1;
            this.difficultyLabel.Text = "Difficulty level (easy, medium, hard)";
            this.difficultyLabel.Visible = false;
            // 
            // nameSubButton
            // 
            this.nameSubButton.Location = new System.Drawing.Point(277, 35);
            this.nameSubButton.Name = "nameSubButton";
            this.nameSubButton.Size = new System.Drawing.Size(75, 23);
            this.nameSubButton.TabIndex = 2;
            this.nameSubButton.Text = "Submit";
            this.nameSubButton.UseVisualStyleBackColor = true;
            this.nameSubButton.Click += new System.EventHandler(this.nameSubButton_Click);
            // 
            // questSubButton
            // 
            this.questSubButton.Location = new System.Drawing.Point(277, 68);
            this.questSubButton.Name = "questSubButton";
            this.questSubButton.Size = new System.Drawing.Size(75, 23);
            this.questSubButton.TabIndex = 2;
            this.questSubButton.Text = "Submit";
            this.questSubButton.UseVisualStyleBackColor = true;
            this.questSubButton.Visible = false;
            this.questSubButton.Click += new System.EventHandler(this.questSubButton_Click);
            // 
            // diffSubButton
            // 
            this.diffSubButton.Location = new System.Drawing.Point(379, 107);
            this.diffSubButton.Name = "diffSubButton";
            this.diffSubButton.Size = new System.Drawing.Size(75, 23);
            this.diffSubButton.TabIndex = 2;
            this.diffSubButton.Text = "Submit";
            this.diffSubButton.UseVisualStyleBackColor = true;
            this.diffSubButton.Visible = false;
            this.diffSubButton.Click += new System.EventHandler(this.diffSubButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "easy",
            "medium",
            "hard"});
            this.comboBox1.Location = new System.Drawing.Point(252, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "easy";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.answerSubButton);
            this.questionPanel.Location = new System.Drawing.Point(44, 163);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(704, 230);
            this.questionPanel.TabIndex = 4;
            // 
            // answerSubButton
            // 
            this.answerSubButton.Location = new System.Drawing.Point(253, 195);
            this.answerSubButton.Name = "answerSubButton";
            this.answerSubButton.Size = new System.Drawing.Size(75, 23);
            this.answerSubButton.TabIndex = 0;
            this.answerSubButton.Text = "Submit";
            this.answerSubButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.diffSubButton);
            this.Controls.Add(this.questSubButton);
            this.Controls.Add(this.nameSubButton);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.howTextBox);
            this.Controls.Add(this.nameTextBox1);
            this.Name = "Form1";
            this.Text = "Math Quiz!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.questionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox howTextBox;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Button nameSubButton;
        private System.Windows.Forms.Button questSubButton;
        private System.Windows.Forms.Button diffSubButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Button answerSubButton;
    }
}

