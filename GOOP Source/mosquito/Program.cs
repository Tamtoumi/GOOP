using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;

namespace mosquito
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class AppDetector
    {

        //private string[] list = { "Spelunky 2", "Rocket League", "Aa", "BB", "steam" };
        //private string[] list = { "chrome" };
        //List<string> appList = new List<string>( "steam", "Discord", "chrome", "Spelunky 2", "Rocket League" );

        private Process[] myProcesses;

        private Process[] getAllProcesses()
        {
            Process[] localAll = Process.GetProcesses();
            
            return localAll;
        }


        private void detectBadApplication()
        {
            Array.Clear(myProcesses, 0, myProcesses.Length);
            myProcesses = getAllProcesses();
            List<string> curr_list = new List<string>();
            bool set = false;
            string[] list = AppMan.BadAppString(); // Ross's function
            int chromeTime = 0;
            foreach (string badApp in list)
            {

                
                foreach (Process process in myProcesses)
                {
                    
                    if (process.ProcessName + ".exe" == badApp)
                    {
                        if(process.ProcessName == "chrome")
                        {
                            if (chromeTime != 0)
                            {
                                continue;
                            }
                        }
                        // Call Henry's function to toggle the system preventer
                        //Form1.set_detector(true);
                        set = true;
                        Console.WriteLine("Bad Application " + process.ProcessName + " detected!: Toggle System Preventor.");
                        curr_list.Add(process.ProcessName);
                        chromeTime = 1;
                    }
                }
            }
            if (set)
            {
                detection_signals.set_detector(true);
                foreach (string word in curr_list)
                {
                    Console.WriteLine(word);
                }
                
                initialAnnoyanceWindow.update_Annoyance_List(curr_list);
            }
            else
            {
                Console.WriteLine("No bad application detected....for now.");
                detection_signals.set_detector(false);
            }
            // Call Henry's function to toggle the system preventer
        }

        //static void Main(string[] args)
        //{
        //    // //PRINT OUT ALL RUNNING PROCESSES

        //    //foreach (Process process in detector.myProcesses) {
        //    //    Console.WriteLine(process.ProcessName);
        //    //}


        //    Timer aTimer = new Timer();
        //    aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        //    aTimer.Interval = 10000;
        //    aTimer.Enabled = true;

        //    Console.WriteLine("Press \'q\' to quit the sameple.");
        //    while (Console.Read() != 'q') ;

        //}

        public static void appDetectorUpdater()
        {
            // Get list from Ross and save it into a local string array
            AppDetector detector = new AppDetector();
            detector.myProcesses = detector.getAllProcesses();
            detector.detectBadApplication();
        }
    }

    public class detection_signals
    {
        public static bool detected_check = false;
        public static bool freetime_check = false;

        public static void set_detector(bool check)
        {
            detected_check = check;
        }

        public void set_freetime(bool freetime)
        {
            freetime_check = freetime;
        }
    }


    // Author: Ross Browning
    // @brief The AppMan class checks through all drivers for installed executables and saves them to a file for first time set up.
    //        The user is able to input Bad Applications that are distracting to them. 
    //        This input is saved in a file that the user can update by opening the Application Manager Form. 
    //        Both files are saved to the user's Desktop as .txt files.
    //
    class AppMan
    {
        // @brief Update the inputted File with the inputted string
        // @param input A string containg text to be saved to a file
        // @param fileName A string containing the .txt file to be saved to 
        // @return Void
        public static void UpdateFile(string input, string fileName)
        {

            string[] new_input = input.Split(':');
            input = new_input[1];
            Console.WriteLine(input);

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

        // @brief Format the path to the Desktop with the incoming text file
        // @param textFile A string that contains the .txt file to format with the Desktop Path
        // @return path A string formatted with the Desktop Path and .txt file
        public static string FormatPath(string textFile)
        {
            string path = string.Format(@"{0}{1}", Globals.path, textFile);
            return path;
        }

        // @brief Return the Bad App List from the file
        // @param none
        // @return A sorted string[] with no duplicates filled with the Bad Application list saved from the BadApps.txt file
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

        // @brief Return the Installed apps from the file
        // @param none
        // @return A sorted string[] with no duplicates filled with the Installed Applications from the InstalledApps.txt file
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

        // @brief Delete an unwanted Bad Application from the saved file
        // @param input A string that user inputs to delete from the Bad Application List
        // @return Void
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

        // @brief Checks if the file already has the input saved
        // @param path A string with the path to the current file being read through
        // @param input A string that is being compared to the current file to see if already saved
        // @return found A bool where true = input is in the current file path and false otherwise
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

        // @brief Takes in a text box to be updated and the string array of text 
        //        Updates the text box on the form being used with the text
        // @param textBox A RichTextBox (form text box for GUI) that is to be updated for the user
        // @param text A string[] that is to be displayed in the textBox
        // @return Void
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

        // @brief For all drivers, check the Program Files and Programs Files (x86) for .exe files and gather them into a string array
        //        using AppMan.TraverseTree and AppMan.StrCombine
        // @param none
        // @return void
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
                        sw.WriteLine(i + ":" + element);
                        i++;
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(newpath))
                    {
                        sw.WriteLine(i + ":" + element);
                        //Console.WriteLine("Added: " + input);
                        i++;
                    }
                }
            }
            //Console.WriteLine(installedApps);

            //return installedApps;
            return;
        }

        // @brief Traverse through the directory given in the parameter 
        // @param root A string containing the root directory to be examined for .exe files
        // @return A string[] containing all .exe file names found in the current root directory
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

        // @brief StrCombine takes in 2 string arrays and combines them to return a single string array
        // @param arr1 First string[] that is to be combined
        // @param arr2 Second string[] that is to be combined
        // @return combine A string[] of the combined arr1 and arr2 with duplicates removed (AppMan.StrRemDup) and sorted (AppMan.StrSort)
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

        // @brief StrRemDup will remove duplicates from a string array
        // @param s A string[] to be filtered for uniqueness
        // @return result A string[] with no duplicates
        private static string[] StrRemDup(string[] s)
        {
            HashSet<string> set = new HashSet<string>(s);
            string[] result = new string[set.Count];
            set.CopyTo(result);
            return result;
        }

        // @brief StrSort will sort the string array in ABC order
        // @param s A string[] to be sorted
        // @return s A sorted string[]
        private static string[] StrSort(string[] s)
        {
            s = s.OrderBy(p => p).ToArray();
            return s;
        }

        // @brief Creates SavedUserAssignments.txt is not there.
        // @return Void
        public static void makeSavedUserAssignments()
        {
             string newpath = FormatPath("\\SavedUserAssignments.txt");
             if (!File.Exists(newpath))
             {
                //Create SUA.txt
                File.Create(newpath);
             }
        }

        // @brief Update TaskViewer by adding SavedUserAssignments.txt and modifying it.
        // @param input A string containg text to be saved to a file
        // @return Void
        public static void updateSavedUserAssignments(string input)
        {
            string newpath = FormatPath("\\SavedUserAssignments.txt");
            using (StreamWriter sw = File.AppendText(newpath))
            {
                sw.Write(input + "`");
            }
        }

        // @brief Update TaskViewer by adding SavedUserAssignments.txt and modifying it.
        // @param input A string containg text to be saved to a file
        // @return Void
        public static string[] readSavedUserAssignments()
        {
            string newpath = FormatPath("\\SavedUserAssignments.txt");
            string rawSUA;
            rawSUA = File.ReadAllText(newpath);
            string[] SUA = rawSUA.Split('`');
            return SUA;
        }


        // @brief Update TaskViewer by adding SavedUserAssignments.txt and modifying it.
        // @param input A string containg text to be saved to a file
        // @return Void
        public static bool eraseFromSavedUserAssignments(string PossibleCompleteTask)
        {
            string newpath = FormatPath("\\SavedUserAssignments.txt");
            string rawSUA;
            rawSUA = File.ReadAllText(newpath);
            string[] SUA = rawSUA.Split('`');
            List<string> SUAList = SUA.Cast<string>().ToList();
            SUAList.Remove("");
            if (SUAList.Remove(PossibleCompleteTask))
            {
                File.WriteAllText(newpath, String.Empty);
                foreach (string task in SUAList)
                {
                    AppMan.updateSavedUserAssignments(task);
                }
                return true;
            }
            else 
                return false;
        }

        // @brief Update TaskViewer by adding SavedUserAssignments.txt and modifying it.
        // @param input A string containg text to be saved to a file
        // @return Void
        public static void cleanSUA()
        {
            string newpath = FormatPath("\\SavedUserAssignments.txt");
            string rawSUA;
            rawSUA = File.ReadAllText(newpath);

            char[] rawSUAchars = rawSUA.ToCharArray();  
            int i = 0;
            foreach (char possableBacktick in rawSUAchars)  
            {  
                if (possableBacktick == '`')
                {
                    if (rawSUAchars.Length >= i++ && rawSUAchars[i++] == '`')
                    {
                        try 
                        { 
                        rawSUAchars = new string(rawSUAchars).Remove(i,i).ToCharArray();
                        } catch { }
                        i--;
                    }
                        
                }
                i++;
            }   
            string[] SUA = rawSUA.Split('`');
            File.WriteAllText(newpath, String.Empty);
            foreach (string task in SUA)
            {
                AppMan.updateSavedUserAssignments(task);
            }
        }

    }
}
