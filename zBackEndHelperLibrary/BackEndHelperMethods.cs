using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace zBackEndHelperLibrary
{
    public class BackEndHelperMethods
    {

        
        public static void ReadingFromCSVFile()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Writting on the array and assigning to App classes");
            string textFilePath = @"C:\21901713LuisCabezosFiles\Sample.csv";

            string[] allLines = File.ReadAllLines(textFilePath);
            Subject[] subjects = new Subject[allLines.Length];

            AddLinesToArray(allLines, subjects);

            DisplaySubjects(subjects);
        }

        private static void AddLinesToArray(string[] allLines, Subject[] subjects)
        {
            for (int i = 0; i < allLines.Length; i++)
            {
                string[] lineSplit = allLines[i].Split(',');
                subjects[i] = new Subject();

                try
                {
                    subjects[i].CourseName = lineSplit[0].Trim();
                    if (String.IsNullOrEmpty(subjects[i].CourseName))
                    {
                        subjects[i].CourseName = "***NO SUBJECT***";
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                try
                {
                    subjects[i].SubjectName1 = lineSplit[1].Trim();
                    if (String.IsNullOrEmpty(subjects[i].SubjectName1))
                    {
                        subjects[i].SubjectName1 = "***NO SUBJECT***";
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                try
                {
                    subjects[i].SubjectName2 = lineSplit[2].Trim();
                    if (String.IsNullOrEmpty(subjects[i].SubjectName2))
                    {
                        subjects[i].SubjectName2 = "***NO SUBJECT***";
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                try
                {
                    subjects[i].SubjectName3 = lineSplit[3].Trim();
                    if (String.IsNullOrEmpty(subjects[i].SubjectName3))
                    {
                        subjects[i].SubjectName3 = "***NO SUBJECT***";
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                try
                {

                    subjects[i].SubjectName4 = lineSplit[4].Trim();
                    if (String.IsNullOrEmpty(subjects[i].SubjectName4))
                    {
                        subjects[i].SubjectName4 = "***NO SUBJECT***";
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                    throw;
                }

                try
                {
                    subjects[i].SubjectName5 = lineSplit[5].Trim();
                    if (String.IsNullOrEmpty(subjects[i].SubjectName5))
                    {
                        subjects[i].SubjectName5 = "***NO SUBJECT***";
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }
        }

        public static void CreateFilePath()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Creating the file path to allow and locate the *.csv file");
            DirectoryInfo newDataDir = new DirectoryInfo(@"C:\21901713LuisCabezosFiles\");
            if (!newDataDir.Exists)
            {
                try
                {
                    newDataDir.Create();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tDirectory creation at \"{0}\": SUCCESSFUL", newDataDir);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***\tERROR***. Exception found: {0}", e.ToString());
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tDiretory already exists. Hence the ConsoleApp will not create the folder path");
            }
            
        }

        public static void CreateFileCSV()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Starting background method to write on the file created");
            string textFilePath = @"C:\21901713LuisCabezosFiles\Sample.csv";

            try
            {
                StreamWriter sw = File.CreateText(textFilePath);
                sw.WriteLine("Maths, addition, substraction, division, multiplication, logs");
                sw.WriteLine("Programming, loops, types, conditionals,,");
                sw.Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tFile creation at \"{0}\": SUCCESSFUL", textFilePath);
                Console.WriteLine("\t***OPENING THE FOLDER IN WINDOWS FILE EXPLORER");
                Process.Start("explorer.exe", @"C:\21901713LuisCabezosFiles");
                

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t ***ERROR***. Exception found: {0}", e.ToString());
            }

        }

        public static void CheckIfFileExists()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Checking if file already exists");
            Console.ForegroundColor = ConsoleColor.White;
            string filePath = @"C:\21901713LuisCabezosFiles\Sample.csv";

            if (File.Exists(filePath))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tFile already exists. Console App will not create a new one");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tFile DOESN'T Exist. Console App will proceed to create the file.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tCreating CSV file at {0}", filePath);
                CreateFileCSV();
                Console.ForegroundColor = ConsoleColor.White;
            }

            
        }
        private static void DisplaySubjects(Subject[] subjects)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please press ENTER key to continue");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Displaying all the fields read form the Sample.csv file:\n");
            foreach (var item in subjects)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Course Name:\t{0}", item.CourseName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Subject1 Name:\t{0}", item.SubjectName1);
                Console.WriteLine("Subject2 Name:\t{0}", item.SubjectName2);
                Console.WriteLine("Subject3 Name:\t{0}", item.SubjectName3);
                Console.WriteLine("Subject4 Name:\t{0}", item.SubjectName4);
                Console.WriteLine("Subject5 Name:\t{0}\n\n", item.SubjectName5);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void AskForDeletion()
        {
            string textFilePath = @"C:\21901713LuisCabezosFiles";
            DirectoryInfo dataDir = new DirectoryInfo(textFilePath);
            dataDir.Delete(true);

        }
    }
}
