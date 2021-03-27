using System;
using System.IO; 
using System.Threading.Tasks;

namespace GOOP
{
    class ProgressTracker
    { 
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            makeUserAssignments();
            writeToUserAssignments(); //writing to a file
        }
        */
        public static async Task writeToUserAssignments()
        {
            string[] lines =
            {
                "First Asgn", "Second Asgn", "Third Asgn" 
            };
            await File.WriteAllLinesAsync(@"UserAssignments.txt", lines);
        }

        public static async Task makeUserAssignments()
        {
            string fileName = @"UserAssignments.txt"; 
            if (!File.Exists(fileName))    
            {    
                File.Create(fileName);    
            }    
        }
    }
}