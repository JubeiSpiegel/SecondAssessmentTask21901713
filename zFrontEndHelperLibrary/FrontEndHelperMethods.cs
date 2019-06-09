using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using zBackEndHelperLibrary;


namespace zFrontEndHelperLibrary
{
    public class FrontEndHelperMethods
    {
        public static void ExerciseDetails()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("John Rowley's Class Assessment Tasks");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Course Name:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Diploma in Visual C# Programming with Visual Studio");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Student:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Luis Cabezos");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Student ID:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("21901713");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Exercise Date:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("08/06/2019");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSECOND EXERCISE:");
            Console.WriteLine("*******************************");
            Console.WriteLine("Console Program: READ FROM FILE");
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Reuse your Course class from part 1 Create a class for each subject. " +
                "\nEach course can have up to five subjects. " +
                "\nManually create a CSV file that contains the class name and  the subjects (blank entries are emtpy commas - see below (Maths and Programming are the subjects)" +
                "\n\t- Maths, addition, subtraction, division, multiplication, logs" +
                "\n\t- Programming, loops, types, conditionals,," +
                "\nRead the data from the file and output each course and the list of subjects associated with it");

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("");
            Console.WriteLine("Press 'ENTER' key to continue");
            Console.ReadLine();
            Console.Clear();

        }

        public static void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What this application doeS is the following:" +
                "\n\nIt checks if on your 'C:\\' drive there's a folder called '21901713LuisCabezosFiles'" +
                "\n\nIF it doesn't exist, the console app will create that path automatically" +
                "\n\nAfter that it checks if inside that path there's a file called 'Sample.csv'" +
                "\n\nIf it doesn't exist, the console app will create the file automatically" +
                "\n\nOn the file created ('Sample.csv'), it will write the details comma separated suggested on the Exercise description" +
                "\n\nAfter that another method will read that .csv file and convert the elements of it into items in an array" +
                "\n\nInternal Logic will assign item to Course property or Subject Property" +
                "\n\nAfter that, as the final step required, it will show all the elements divided in the following schema:" +
                "\n- Course Name" +
                "\n- Subject1 Name" +
                "\n- Subject2 Name" +
                "\n- Subject3 Name" +
                "\n- Subject4 Name" +
                "\n- Subject5 Name" +
                "\n\nIt will ask if you want to delete all folders and files created");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press 'ENTER' key to continue");
            Console.ReadLine();
            Console.Clear();

        }

        

        public static void Signature()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("21901713 / Luis Cabezos / John Rowley's Class Assessment Tasks / 2019");

        }

        public static void Goodbye()
        {
            char deleteChoice;

            deletionChoice:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Do you want to delete all folders and files created on this process? [Y/N]: ");
            try
            {
                deleteChoice = char.Parse(Console.ReadLine().ToUpper());
                if (deleteChoice == 'Y')
                {
                    BackEndHelperMethods.AskForDeletion();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tDELETION COMPLETE");
                    Signature();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Thanks for using this app!");
                    Console.WriteLine("Press any key to FINISH...");
                }
                else if (deleteChoice == 'N')
                {
                    Signature();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Thanks for using this app!");
                    Console.WriteLine("Press any key to FINISH...");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***ERROR INPUT***: Please enter as character [Y] or [N]");
                    goto deletionChoice;
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***ERROR INPUT: Please enter only a character");
                Console.WriteLine("***ERROR***: {0}", e);
                goto deletionChoice;
                throw;
            }


           
           
        }
    }
}
