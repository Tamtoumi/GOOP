using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace mosquito
{
    public partial class Form1 : Form
    {
        int chosen = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            GUI.setFormVisuals(this, title);
            GUI.btnSetUp(btnAppMan);
            GUI.btnSetUp(btnTaskView);
            GUI.btnSetUp(btnFirstTimeSetUp);

            // sets the form to a fixed size 
            this.MinimumSize = new Size(425, 400);
            this.MaximumSize = new Size(425, 400);
            this.Text = "Start Up";
            // changes the default font size 
            btnAppMan.Font = new System.Drawing.Font("Nirmala UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTaskView.Font = new System.Drawing.Font("Nirmala UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnFirstTimeSetUp.Font = new System.Drawing.Font("Nirmala UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Loading...Give it a second. ", "Loading");
            ApplicationManager myForm = new ApplicationManager();
            myForm.ShowDialog();
            this.Hide();
            //this.Close();

        }

        private void btnTaskView_Click(object sender, EventArgs e)
        {
            
            TaskViewer newForm = new TaskViewer();
            newForm.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (chosen == 1)
            //{
            //    MessageBox.Show("Loading...Give it a second. ", "Loading");
            //    ApplicationManager myForm = new ApplicationManager();
            //    myForm.ShowDialog();
            //}
            //else if (chosen == 2)
            //{
            //    TaskViewer newForm = new TaskViewer();
            //    newForm.Show();
            //}
        }

        private void btnFirstTimeSetUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...Give it a second. ", "Loading");
            AppMan.Drivers();
            ApplicationManager myForm = new ApplicationManager();
            myForm.ShowDialog();
            this.Hide();
        }
    }
    public static class Globals
    {
        public static String path = @"C:\Users\Ross\Desktop"; // Modifiable
        //public static String path = @"C:\Users\Angel\Documents\GitHub";
    }


    class AppMan
    {
        public static void UpdateFile(string input, string fileName)
        {
            string newpath = FormatPath(fileName);
            //string path = @"C:\Users\Ross\Desktop\BadApps.txt";
            if (!File.Exists(newpath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(newpath))
                {
                    sw.WriteLine(input);
                }
            }
            else
            {
                if (lineFound(newpath, input))
                {
                    AppInputtedAlready myForm = new AppInputtedAlready();
                    myForm.ShowDialog();
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(newpath))
                    {
                        sw.WriteLine(input);
                        //Console.WriteLine("Added: " + input);
                    }
                }
            }
            /*
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }*/
        }

        public static string FormatPath(string textFile)
        {
            string path = string.Format(@"{0}{1}", Globals.path, textFile);
            return path;
        }
        public static string[] BadAppString()
        {
            string newpath = FormatPath("\\BadApps.txt");
            string line;
            // Read the file and display it line by line.  
            if (!File.Exists(newpath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(newpath))
                {
                    //sw.WriteLine(input);
                }
            }
            System.IO.StreamReader file =
                new System.IO.StreamReader(newpath);
            List<string> stringList = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                stringList.Add(line);
            }
            file.Close();
            return AppMan.StrSort(stringList.ToArray());
        }

        public static string[] InstalledAppString()
        {
            string newpath = FormatPath("\\InstalledApps.txt");
            string line;
            // Read the file and display it line by line.  
            if (!File.Exists(newpath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(newpath))
                {
                    //sw.WriteLine(input);
                }
            }
            System.IO.StreamReader file =
                new System.IO.StreamReader(newpath);
            List<string> stringList = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                stringList.Add(line);
            }
            file.Close();
            return stringList.ToArray();
        }

        public static void DeleteBadApp(string input)
        {
            string newpath = FormatPath("\\BadApps.txt");
            //string path = @"C:\Users\Ross\Desktop\BadApps.txt";
            if (lineFound(newpath, input))
            {
                string tempFile = Path.GetTempFileName();
                using (var sr = new StreamReader(newpath))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != input)
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                File.Delete(newpath);
                File.Move(tempFile, newpath);
            }
            else
            {
                //InvalidApp myForm = new InvalidApp();
                //myForm.ShowDialog();
            }
        }

        private static bool lineFound(string path, string input)
        {
            bool found = false;
            using (var sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line == input)
                    {
                        found = true;
                    }
                }
            }
            return found;
        }

        public static void UpdateTextBox(System.Windows.Forms.RichTextBox textBox, string[] text)
        {
            //string[] list = AppMan.BadAppString();
            string[] list = text;
            textBox.Text = "";
            for (int j = 0; j < list.Length; j++)
            {
                //Console.WriteLine(list[i]);
                textBox.Text += list[j] + "\n";
            }
        }

        public static void Drivers()
        {
            string[] installedApps = null;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                string files1 = "Program Files";
                string path1 = string.Format(@"{0}{1}", d.Name, files1);
                string files2 = "Program Files (x86)";
                string path2 = string.Format(@"{0}{1}", d.Name, files2);
                //Console.WriteLine(path1);
                //Console.WriteLine(installedApps);
                string[] executables1 = TraverseTree(path1);
                installedApps = AppMan.StrCombine(installedApps, executables1);
                //Console.WriteLine(installedApps);
                //Console.WriteLine(path2);
                string[] executables2 = TraverseTree(path2);
                installedApps = AppMan.StrCombine(installedApps, executables2);
                //Console.WriteLine(installedApps);
            }
            string newpath = FormatPath("\\InstalledApps.txt");
            int i = 0;
            File.Delete(newpath);
            foreach (string element in installedApps)
            {
                //Console.WriteLine(element);
                if (!File.Exists(newpath))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(newpath))
                    {
                        sw.WriteLine(i + ": " + element);
                        i++;
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(newpath))
                    {
                        sw.WriteLine(i + ": " + element);
                        //Console.WriteLine("Added: " + input);
                        i++;
                    }
                }
            }
            //Console.WriteLine(installedApps);

            //return installedApps;
            return;
        }
        private static string[] TraverseTree(string root)
        {
            // Data structure to hold names of subfolders to be
            // examined for files.
            Stack<string> dirs = new Stack<string>(20);

            if (!System.IO.Directory.Exists(root))
            {
                //throw new ArgumentException();
                return null;
            }
            dirs.Push(root);
            List<string> listofexe = new List<string>();
            int count = 0;
            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs;
                try
                {
                    subDirs = System.IO.Directory.GetDirectories(currentDir);
                }
                // An UnauthorizedAccessException exception will be thrown if we do not have
                // discovery permission on a folder or file. It may or may not be acceptable
                // to ignore the exception and continue enumerating the remaining files and
                // folders. It is also possible (but unlikely) that a DirectoryNotFound exception
                // will be raised. This will happen if currentDir has been deleted by
                // another application or thread after our call to Directory.Exists. The
                // choice of which exceptions to catch depends entirely on the specific task
                // you are intending to perform and also on how much you know with certainty
                // about the systems on which this code will run.
                catch (UnauthorizedAccessException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }
                string[] files = null;
                try
                {
                    files = System.IO.Directory.GetFiles(currentDir, "*.exe");
                }

                catch (UnauthorizedAccessException e)
                {

                    //Console.WriteLine(e.Message);
                    continue;
                }

                catch (System.IO.DirectoryNotFoundException e)
                {
                    //Console.WriteLine(e.Message);
                    continue;
                }
                // Perform the required action on each file here.
                // Modify this block to perform your required task.

                foreach (string file in files)
                {
                    try
                    {
                        // Perform whatever action is required in your scenario.
                        System.IO.FileInfo fi = new System.IO.FileInfo(file);
                        //Console.WriteLine("{0}: {1}, {2}", fi.Name, fi.Length, fi.CreationTime);
                        //Console.WriteLine(file);
                        //Console.WriteLine("{0}:   {1}", count, fi.Name);
                        listofexe.Add(fi.Name);
                        count++;
                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        // If file was deleted by a separate application
                        //  or thread since the call to TraverseTree()
                        // then just continue.
                        //Console.WriteLine(e.Message);
                        continue;
                    }
                }

                // Push the subdirectories onto the stack for traversal.
                // This could also be done before handing the files.
                foreach (string str in subDirs)
                    dirs.Push(str);

            }
            return listofexe.ToArray();
        }

        private static string[] StrCombine(string[] arr1, string[] arr2)
        {
            try
            {
                if (arr1 == null)
                    return arr2;
            }
            catch (NullReferenceException e)
            {
                return arr2;
            }
            try
            {
                if (arr2 == null)
                    return arr1;
            }
            catch (NullReferenceException e)
            {
                return arr1;
            }

            string[] combine = new string[arr1.Length + arr2.Length];
            Array.Copy(arr1, combine, arr1.Length);
            Array.Copy(arr2, 0, combine, arr1.Length, arr2.Length);
            combine = AppMan.StrRemDup(combine);
            combine = AppMan.StrSort(combine);
            return combine;
        }

        private static string[] StrRemDup(string[] s)
        {
            HashSet<string> set = new HashSet<string>(s);
            string[] result = new string[set.Count];
            set.CopyTo(result);
            return result;
        }

        private static string[] StrSort(string[] s)
        {
            s = s.OrderBy(p => p).ToArray();
            return s;
        }
    }
}
