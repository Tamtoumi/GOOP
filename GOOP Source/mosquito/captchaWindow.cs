using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mosquito
{
    ///Author: Henry Reynaud
    /// <summary>
    /// A captcha window, which is one form of annoyance for the user that is spawned 
    /// from the initialAnnoyanceWindow. The user must select the correct pictures from
    /// the given nine to close this window. If they try to exit out before completing it, 
    /// or complete it incorrectly, another captcha window will be created in its place.
    /// The images are grabbed from a local file of images, and they are randomly arranged
    /// in the nine possible locations. 
    /// </summary>
    public partial class captchaWindow : Form
    {
        //used to create the random usage of the pictures in the captcha
        System.Random random = new System.Random();
        private bool[] correct = new bool[9];
        
        //values given from the parent initialAnnoyanceWindow and also to see if the captcha was completed
        public bool completed = false;
        public initialAnnoyanceWindow parent;
        private int level;

        /// <summary>
        /// Constructor for the captcha window
        /// </summary>
        public captchaWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Second constructor for the captcha windows, which saves the parent instance of the 
        /// initialAnnoyanceWindow which created it, and which level of annoyance it is in. 
        /// Also sets of the nine images in the form by randomly selecting images from the 
        /// local folder of images and saves which checkboxes need to be clicked to 
        /// correctly complete the captcha window.
        /// </summary>
        /// <param name="from">
        /// The initialAnnoyanceWindow that created this captcha window.
        /// </param>
        /// <param name="given">
        /// The level of annoyance that this captcha window was created in.
        /// </param>
        public captchaWindow(initialAnnoyanceWindow from, int given)
        {
            InitializeComponent();
            parent = from;
            level = given;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            int index = 0;
            int number1;
            int number2;
            List<int> validNumbers = new List<int>();
            List<int> invalidNumbers = new List<int>();
            foreach (var checkBox in this.Controls.OfType<CheckBox>())
            {
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderColor = Color.Black;
                checkBox.FlatAppearance.BorderSize = 5;

                double choice = random.NextDouble();


                if (choice >= 0.5)
                {
                    do
                    {
                        number1 = random.Next(1, 9);
                    } while (validNumbers.Contains(number1));
                    validNumbers.Add(number1);

                    correct[index] = true;

                    //checkBox.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    string path = Directory.GetParent(Directory.GetParent(System.Windows.Forms.Application.StartupPath).FullName).FullName;
                    var loaded = Image.FromFile(path + @"\validPics\image" + number1.ToString() + ".jpg");
                    checkBox.Image = resizeImage(loaded, new Size(100, 100));

                }
                else
                {
                    do
                    {
                        number2 = random.Next(1, 9);
                    } while (invalidNumbers.Contains(number2));
                    invalidNumbers.Add(number2);

                    correct[index] = false;
                    //checkBox.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    string path = Directory.GetParent(Directory.GetParent(System.Windows.Forms.Application.StartupPath).FullName).FullName;
                    var loaded = Image.FromFile(path + @"\invalidPics\image" + number2.ToString() + ".jpg");
                    checkBox.Image = resizeImage(loaded, new Size(100, 100));
                }
                index++;
            }

        }

        /// <summary>
        /// Function used to resize the images to correctly fit them into the checkboxes
        /// on the form.
        /// </summary>
        /// <param name="imgToResize">
        /// The image that needs to be resized
        /// </param>
        /// <param name="size">
        /// The desired size of the output image.
        /// </param>
        /// <returns></returns>
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        private void captchaWindow_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Each checkbox had to have its checkChanged function done 
        /// individually, but they each simply change the border color
        /// of the checkbox to green when selected to help the user see
        /// which ones they have already clicked on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.FlatAppearance.BorderColor == Color.Black)
            {
                checkBox1.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                checkBox1.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.FlatAppearance.BorderColor == Color.Black)
            {
                checkBox2.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                checkBox2.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.FlatAppearance.BorderColor == Color.Black)
            {
                checkBox3.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                checkBox3.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.FlatAppearance.BorderColor == Color.Black)
            {
                checkBox4.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                checkBox4.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.FlatAppearance.BorderColor == Color.Black)
            {
                checkBox5.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                checkBox5.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.FlatAppearance.BorderColor == Color.Black)
            {
                checkBox6.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                checkBox6.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.FlatAppearance.BorderColor == Color.Black)
            {
                checkBox7.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                checkBox7.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.FlatAppearance.BorderColor == Color.Black)
            {
                checkBox8.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                checkBox8.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.FlatAppearance.BorderColor == Color.Black)
            {
                checkBox9.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                checkBox9.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The submit button on the form. When clicked by the user, it
        /// checks through each checkbox and makes sure that the correct 
        /// checkboxes were clicked on and that the wrong ones were not 
        /// selected. It sets the completed value appropriately and closes
        /// this instance of the captcha window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool isChecked;
            int index = 0;

            foreach (var checkBox in this.Controls.OfType<CheckBox>())
            {
                completed = true;
                isChecked = correct[index] && checkBox.Checked || !correct[index] && !checkBox.Checked;

                if (!isChecked)
                {
                    completed = false;
                    break;
                }

                index++;
            }

            this.Close();

        }

        /// <summary>
        /// Closing function for the window. Either opens a new captcha window
        /// or returns to the initialAnnoyanceWindow, depending on if the 
        /// captcha was completed successfully.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void captchaWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!completed)
            {
                captchaWindow newform = new captchaWindow(parent, level);
                newform.Show();
            }
            
            else
            {
                parent.returnFromLevel(level);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Prevents this window from being minimized by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void captchaWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
