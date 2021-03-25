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
    public partial class captchaWindow : Form
    {
        System.Random random = new System.Random();
        bool[] correct = new bool[9];
        public bool completed = false;
        initialAnnoyanceWindow parent;
        int level;

        public captchaWindow()
        {
            InitializeComponent();
        }

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

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        private void captchaWindow_Load(object sender, EventArgs e)
        {

        }

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

        private void captchaWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
