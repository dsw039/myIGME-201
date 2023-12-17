using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMath
{
    public partial class Form1 : Form
    {
        // store user name
         string myName = "";

        // string and int of # of questions
        string sQuestions = "";
        int nQuestions = 0;

        // string and base value related to difficulty
        string sDifficulty = "";
        int nMaxRange = 0;

        // constant for setting difficulty with 1 variable
        const int MAX_BASE = 10;

        // question and # correct counters
        int nCntr = 0;
        int nCorrect = 0;

        // operator picker
        int nOp = 0;

        // operands and solution
        int val1 = 0;
        int val2 = 0;
        int nAnswer = 0;

        // string and int for the response
        string sResponse = "";
        Int32 nResponse = 0;

        // play again?
        string sAgain = "";

        // valid state
        bool bValid = false;


            // seed the random number generator
            Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch (sDifficulty)
            {
                case "easy":
                    nMaxRange = MAX_BASE;

                    break;

                case "medium":
                case "med":
                    nMaxRange = MAX_BASE * 2;
                    break;

                case "hard":
                    nMaxRange = MAX_BASE * 3;
                    break;
            }



        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void nameSubButton_Click(object sender, EventArgs e)
        {
            //the name of the user is saved in myName
            myName = nameTextBox1.Text;
            //When the button is clicked, the next question and the textbox for the answer to that question becomes visible and usable, if something has been typed in the textbox
            if(myName.Length > 0)
            {
                questionLabel.Enabled = true;
                questionLabel.Visible = true;

                howTextBox.Enabled = true;
                howTextBox.Visible = true;

                questSubButton.Enabled = true;
                questSubButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void questSubButton_Click(object sender, EventArgs e)
        {
            //The number of questions that the user wants is saved into sQuestions
            sQuestions = howTextBox.Text;
            //When the button is clicked, the next question and the textbox for the answer to that question becomes visible and usable, if something has been typed in the textbox
            if(sQuestions.Length > 0)
            {
                difficultyLabel.Enabled = true;
                difficultyLabel.Visible = true;

                comboBox1.Enabled = true;
                comboBox1.Visible = true;

                diffSubButton.Enabled = true;
                diffSubButton.Visible = true;
            }
        }

        private void diffSubButton_Click(object sender, EventArgs e)
        {
            //Set everything that was visible before to invisble
            nameLabel.Enabled = false;
            nameLabel.Visible = false;

            nameTextBox1.Enabled = false;
            nameTextBox1.Visible = false;

            nameSubButton.Enabled = false;
            nameSubButton.Visible = false;

            questionLabel.Enabled = false;
            questionLabel.Visible = false;

            howTextBox.Enabled = false;
            howTextBox.Visible = false;

            questSubButton.Enabled = false;
            questSubButton.Visible = false;

            difficultyLabel.Enabled = false;
            difficultyLabel.Visible = false;

            comboBox1.Enabled = false;
            comboBox1.Visible = false;

            diffSubButton.Enabled = false;
            diffSubButton.Visible = false;

            sDifficulty = comboBox1.SelectedItem.ToString();

            GenerateQuestion();

            //Displays first question
            questionPanel.Enabled = true;
            questionPanel.Visible = true;
            DisplayNextQuestion();

        }

        private void howTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, Backspace, and Enter
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being processed
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private string GenerateQuestion()
        {
            // Generate a random operation (addition, subtraction, multiplication)
            int nOp = rand.Next(0, 3);

            // Generate random operands based on the difficulty level (nMaxRange)
            int val1 = rand.Next(0, nMaxRange) + nMaxRange;
            int val2 = rand.Next(0, nMaxRange);

            // Ensure that neither operand is 0
            while (val1 == 0 || val2 == 0)
            {
                val1 = rand.Next(0, nMaxRange) + nMaxRange;
                val2 = rand.Next(0, nMaxRange);
            }

            int nAnswer = 0;
            string question = "";

            // Generate the question based on the random operation
            switch (nOp)
            {
                case 0:
                    nAnswer = val1 + val2;
                    question = $"Question #{nCntr + 1}: {val1} + {val2} ==> ";
                    break;
                case 1:
                    nAnswer = val1 - val2;
                    question = $"Question #{nCntr + 1}: {val1} - {val2} ==> ";
                    break;
                case 2:
                    nAnswer = val1 * val2;
                    question = $"Question #{nCntr + 1}: {val1} * {val2} ==> ";
                    break;
            }

            return question;
        }

        private void DisplayNextQuestion()
        {
            if (nCntr < nQuestions)
            {
                // Generate a new question
                string question = GenerateQuestion();

                // Create a new label for the question
                Label newLabel = new Label
                {
                    Text = question,
                    Location = new Point(60, 100 + nCntr + 2), // Adjust the Y position based on the question number
                    AutoSize = true
                };

                // Create a new textbox for the answer
                TextBox newTextBox = new TextBox
                {
                    Name = $"answerTextBox{nCntr}",
                    Location = new Point(100, 100 + nCntr * 30), // Adjust the Y position based on the question number
                    Size = new Size(50, 20),
                    Tag = nCntr // Store the question number as the tag for later reference
                };

                // Add the label and textbox to the panel
                questionPanel.Controls.Add(newLabel);
                questionPanel.Controls.Add(newTextBox);

                // Display the new question
                newLabel.Enabled = true;
                newLabel.Visible = true;

                newTextBox.Enabled = true;
                newTextBox.Visible = true;

                answerSubButton.Enabled = true;
                answerSubButton.Visible = true;

                // Increment the question counter
                nCntr++;
            }
            else
            {
                // User has answered all questions
                // Add code to handle end of the quiz
                // For example, display the score or ask if the user wants to play again
            }
        }


    }
}
