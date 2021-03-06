﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mosquito
{
    /// Author: Henry Reynaud
    /// <summary>
    /// Button trial is another annoyance window created by the initialAnnoyanceWindow.
    /// In this window, the user is shown 25 identical buttons, but only one of them can
    /// close the window. The user cannot minimize, click off, or close the window otherwise.
    /// The correct button is randomly chosen each time the window is created.
    /// </summary>
    public partial class buttonTrial : Form
    {
        //used for choosing a random button and checking if the correct one was clicked
        static System.Random random = new System.Random();
        public List<int> validNumbers = new List<int>();
        private int randomNumber = random.Next(1, 26);

        //values from the parent window, and a bool for if the window was completed successfully
        public initialAnnoyanceWindow parent;
        public int level;
        public bool completed = false;

        /// <summary>
        /// Constructor for the button trial window.
        /// </summary>
        public buttonTrial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Additional constructor for creating it from the initialAnnoyanceWindow, saving the appropriate values.
        /// </summary>
        /// <param name="from">
        /// Instance of parent initialAnnoyanceWindow
        /// </param>
        /// <param name="given_level">
        /// Level of annoyance that the window was created in.
        /// </param>
        public buttonTrial(initialAnnoyanceWindow from, int given_level)
        {
            InitializeComponent();
            level = given_level;
            parent = from;
        }

        /// <summary>
        /// Loading function for the button trial window. Sets the text of each button
        /// to say 'cancel' so they look identical. Also creates a unique random number 
        /// for each button to make only one of them work.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrial_Load(object sender, EventArgs e)
        {
            int number1;

            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Text = "Cancel";

                do
                {
                    number1 = random.Next(1, 26);
                } while (validNumbers.Contains(number1));
                validNumbers.Add(number1);


            }
            //foreach (var button in this.Controls.OfType<Button>())
            //{
            //    if (isTheOne(int.Parse(button.Name.Substring(6))))
            //    {
            //        button.BackColor = Color.Green;
            //    }
            //}
        }

        /// <summary>
        /// A check for each button to see if its unique random number 
        /// matches the chosen random number. If it matches, then it 
        /// is the activated button. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns>
        /// Returns a bool if the button is the usable button. 
        /// </returns>
        private bool isTheOne(int index)
        {
            return validNumbers[index - 1] == randomNumber;
        }


        /// <summary>
        /// Each button click function had to be done individually, but
        /// they all function the same by checking its random number against
        /// the chosen one to see if it should close the window. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (isTheOne(1))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isTheOne(2))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isTheOne(3))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isTheOne(4))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isTheOne(5))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isTheOne(6))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isTheOne(7))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isTheOne(8))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isTheOne(9))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isTheOne(10))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isTheOne(11))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isTheOne(12))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isTheOne(13))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isTheOne(14))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (isTheOne(15))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (isTheOne(16))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (isTheOne(17))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (isTheOne(18))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (isTheOne(19))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (isTheOne(20))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (isTheOne(21))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (isTheOne(22))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (isTheOne(23))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (isTheOne(24))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (isTheOne(25))
            {
                this.Close();
                //do the return function to initialAnnoyanceWindow
            }
        }

        /// <summary>
        /// Closing function for the window. Calls the return function 
        /// to the parent initialAnnoyanceWindow and gives it the level
        /// it was created in. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrial_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.returnFromLevel(level); 
        }

        /// <summary>
        /// SizeChanged function for the window. Prevents the user from minimizing the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrial_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
