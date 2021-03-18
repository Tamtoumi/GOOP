<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sample1
{
    class UpdateFile
    {
        public static class Globals
        {
            public static string path = @"C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt";
        }
        public static void Update(string input)
        {
            //string path = @"C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt";
            if (!File.Exists(Globals.path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(Globals.path))
                {
                    sw.WriteLine(input);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(Globals.path))
                {
                    sw.WriteLine(input);
                    //Console.WriteLine("Added: " + input);
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(Globals.path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void TListR()
        {
            //string path = @"C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt";

            TextReader rtxt = new StreamReader(Globals.path);
            rtxt.ReadToEnd();
            rtxt.Close();
            
        }

        public static void TListW()
        {
            // STREAMWRITER CREATES A NEW FILE...
            //using (StreamWriter sw = File.W(Globals.path))
            //{
            //    sw.WriteLine(input);
            //    //Console.WriteLine("Added: " + input);
            //}
            TextWriter txt = new StreamWriter(Globals.path);
            //txt.Write(txtTask.Text);
           // txt.Write(output);
            txt.Close();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sample1
{
    class UpdateFile
    {
        public static class Globals
        {
            public static string path = @"C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt";
        }
        public static void Update(string input)
        {
            //string path = @"C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt";
            if (!File.Exists(Globals.path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(Globals.path))
                {
                    sw.WriteLine(input);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(Globals.path))
                {
                    sw.WriteLine(input);
                    //Console.WriteLine("Added: " + input);
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(Globals.path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void TListR()
        {
            //string path = @"C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt";

            TextReader rtxt = new StreamReader(Globals.path);
            rtxt.ReadToEnd();
            rtxt.Close();
            
        }

        public static void TListW()
        {
            // STREAMWRITER CREATES A NEW FILE...
            //using (StreamWriter sw = File.W(Globals.path))
            //{
            //    sw.WriteLine(input);
            //    //Console.WriteLine("Added: " + input);
            //}
            TextWriter txt = new StreamWriter(Globals.path);
            //txt.Write(txtTask.Text);
           // txt.Write(output);
            txt.Close();
        }
    }
}
>>>>>>> e582082d5beaddfe72f3be9c5e97671bc5909fea
