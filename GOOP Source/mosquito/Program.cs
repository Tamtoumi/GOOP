using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (string badApp in list)
            {

                
                foreach (Process process in myProcesses)
                {
                    
                    if (process.ProcessName + ".exe" == badApp)
                    {
                        // Call Henry's function to toggle the system preventer
                        //Form1.set_detector(true);
                        set = true;
                        Console.WriteLine("Bad Application " + process.ProcessName + " detected!: Toggle System Preventor.");
                        curr_list.Add(process.ProcessName);
                    }
                }
            }
            if (set)
            {
                detection_signals.set_detector(true);
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
}
