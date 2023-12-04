using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace UnitTest3
{
    public partial class Form1 : Form
    {
        int correctInputs = 0;
        public Form1()
        {
            InitializeComponent();
           // int correctInputs = 0;

            Console.WriteLine("44");

            // timer1.Start();

            
        }

        
          
        
        
        //button code
        private void benRButton_Click(object sender, EventArgs e)
        {
            
            
            webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            harrisonPBox.Visible = true;
        }

        private void frankRButton_Click(object sender, EventArgs e)
        {


            webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
            roosePBox.Visible = true;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (washingtonRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/George_Washington");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
                washingtonPBox.Visible = true;
            }
            else
            {

                washingtonPBox.Visible = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox8.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 35)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Loaded");
            /*
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            */
            

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Console.WriteLine("Timer Tick Event");
            if (progressBar1.Value > progressBar1.Minimum)
            {
                progressBar1.Value--;
            }
            else
            {

                timer1.Stop();
                Application.Restart();
                Environment.Exit(0);
            }
            CheckCorrectInputs();
        }

        private void CheckCorrectInputs()
        {
            if (correctInputs > 16)
            {
                exitButton.Enabled = true;
            }
        }

        private void benRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (benRButton.Checked)
            {
                // Code to execute when benRButton is checked
                
                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
                harrisonPBox.Visible = true;
            }
            else
            {
                // Code to execute when benRButton is unchecked
                harrisonPBox.Visible = false;
            }
        }

        private void frankRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (frankRButton.Checked)
            {
                
                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt";
                roosePBox.Visible = true;
            }
            else
            {
                
                roosePBox.Visible = false;
            }
        }

        private void willRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (willRButton.Checked)
            {
                
                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/William_J_Clinton");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/William_J_Clinton";
                clintonPBox.Visible = true;
            }
            else
            {

                clintonPBox.Visible = false;
            }
        }

        private void jamesRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (jamesRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/James_Buchanan");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
                buchPBox.Visible = true;
            }
            else
            {

                buchPBox.Visible = false;
            }
        }

        private void pierceRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pierceRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
                piercePBox.Visible = true;
            }
            else
            {

                piercePBox.Visible = false;
            }
        }

        private void bushRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bushRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/George_W_Bush");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/George_W_Bush";
                bushPBox.Visible = true;
            }
            else
            {

                bushPBox.Visible = false;
            }
        }

        private void obamaRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (obamaRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Barack_Obama");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
                obamaPBox.Visible = true;
            }
            else
            {

                obamaPBox.Visible = false;
            }
        }

        private void kennedyRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (kennedyRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/John_F_Kennedy");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/John_F_Kennedy";
                kennedyPBox.Visible = true;
            }
            else
            {

                kennedyPBox.Visible = false;
            }
        }

        private void williamRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (williamRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/William_McKinley");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
                mcPBox.Visible = true;
            }
            else
            {

                mcPBox.Visible = false;
            }
        }

        private void ronaldRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ronaldRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
                reaganPBox.Visible = true;
            }
            else
            {

                reaganPBox.Visible = false;
            }
        }

        private void dwightRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dwightRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower";
                eisenPBox.Visible = true;
            }
            else
            {

                eisenPBox.Visible = false;
            }
        }

        private void martinRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (martinRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
                vanPBox.Visible = true;
            }
            else
            {

                vanPBox.Visible = false;
            }
        }

        private void adamsRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (adamsRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/John_Adams");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
                adamsPBox.Visible = true;
            }
            else
            {

                adamsPBox.Visible = false;
            }
        }

        private void theodoreRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (theodoreRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
                theoPBox.Visible = true;
            }
            else
            {

                theoPBox.Visible = false;
            }
        }

        private void thomasRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (thomasRButton.Checked)
            {

                webBrowser1.Url = new Uri("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
                wikiBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
                jeffersonPBox.Visible = true;
            }
            else
            {

                jeffersonPBox.Visible = false;
            }
        }

        private void repubRButton_CheckedChanged(object sender, EventArgs e)
        {
            RepubOnlyRadioButtons();
            
            
        }

        private void RepubOnlyRadioButtons()
        {
            //democrat
            frankRButton.Visible = false;
            willRButton.Visible = false;
            jamesRButton.Visible = false;
            pierceRButton.Visible = false;
            obamaRButton.Visible = false;
            kennedyRButton.Visible = false;
            martinRButton.Visible = false;

            //repub
            benRButton.Visible = true;
            bushRButton.Visible = true;
            williamRButton.Visible = true;
            ronaldRButton.Visible = true;
            dwightRButton.Visible = true;
            theodoreRButton.Visible = true;

            //demo-repub
            thomasRButton.Visible = false;

            //fed
            washingtonRButton.Visible = false;
            adamsRButton.Visible = false;
        }

        private void DemoOnlyRadioButtons()
        {
            //demo 
            frankRButton.Visible = true;
            willRButton.Visible = true;
            jamesRButton.Visible = true;
            pierceRButton.Visible = true;
            obamaRButton.Visible = true;
            kennedyRButton.Visible = true;
            martinRButton.Visible = true;

            //repub
            benRButton.Visible= false;
            bushRButton.Visible = false;
            williamRButton.Visible = false;
            ronaldRButton.Visible = false;
            dwightRButton.Visible = false;
            theodoreRButton.Visible = false;

            //demo-repub
            thomasRButton.Visible = false;

            //fed
            washingtonRButton.Visible = false;
            adamsRButton.Visible = false;
        }

        private void DemoRepubOnlyRadioButtons()
        {
            //demo 
            frankRButton.Visible = false;
            willRButton.Visible = false;
            jamesRButton.Visible = false;
            pierceRButton.Visible = false;
            obamaRButton.Visible = false;
            kennedyRButton.Visible = false;
            martinRButton.Visible = false;

            //repub
            benRButton.Visible = false;
            bushRButton.Visible = false;
            williamRButton.Visible = false;
            ronaldRButton.Visible = false;
            dwightRButton.Visible = false;
            theodoreRButton.Visible = false;

            //demo-repub
            thomasRButton.Visible = true;

            //fed
            washingtonRButton.Visible = false;
            adamsRButton.Visible = false;
        }

        private void FedOnlyRadioButtons()
        {
            //demo 
            frankRButton.Visible = false;
            willRButton.Visible = false;
            jamesRButton.Visible = false;
            pierceRButton.Visible = false;
            obamaRButton.Visible = false;
            kennedyRButton.Visible = false;
            martinRButton.Visible = false;

            //repub
            benRButton.Visible = false;
            bushRButton.Visible = false;
            williamRButton.Visible = false;
            ronaldRButton.Visible = false;
            dwightRButton.Visible = false;
            theodoreRButton.Visible = false;

            //demo-repub
            thomasRButton.Visible = false;

            //fed
            washingtonRButton.Visible = true;
            adamsRButton.Visible = true;
        }

        private void AllRadioButtons()
        {
            //demo 
            frankRButton.Visible = true;
            willRButton.Visible = true;
            jamesRButton.Visible = true;
            pierceRButton.Visible = true;
            obamaRButton.Visible = true;
            kennedyRButton.Visible = true;
            martinRButton.Visible = true;

            //repub
            benRButton.Visible = true;
            bushRButton.Visible = true;
            williamRButton.Visible = true;
            ronaldRButton.Visible = true;
            dwightRButton.Visible = true;
            theodoreRButton.Visible = true;

            //demo-repub
            thomasRButton.Visible = true;

            //fed
            washingtonRButton.Visible = true;
            adamsRButton.Visible = true;
        }
        private void demoRButton_CheckedChanged(object sender, EventArgs e)
        {
            DemoOnlyRadioButtons();
        }

        private void drRButton_CheckedChanged(object sender, EventArgs e)
        {
            DemoRepubOnlyRadioButtons();
        }

        private void fedRButton_CheckedChanged(object sender, EventArgs e)
        {
            FedOnlyRadioButtons();
        }

        private void allRButton_CheckedChanged(object sender, EventArgs e)
        {
            AllRadioButtons();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If it's not a digit or control character, suppress the key press
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 23)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 32)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 42)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 15)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 14)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox6.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 43)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox7.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 44)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox9.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 25)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox10.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 40)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox11.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 34)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox12.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 8)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox13.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 1)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox14.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 2)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox15.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 26)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox16.Text, out int inputValue))
            {
                // Now, inputValue contains the parsed integer value
                if (inputValue == 3)
                {
                    correctInputs += 1;
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 1000;
                    timer1.Start();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
