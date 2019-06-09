using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using zBackEndHelperLibrary;
using zFrontEndHelperLibrary;

namespace ReadFromFileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontEndHelperMethods.ExerciseDetails();
            FrontEndHelperMethods.Intro();

            BackEndHelperMethods.CreateFilePath();
            BackEndHelperMethods.CheckIfFileExists();
            BackEndHelperMethods.ReadingFromCSVFile();

            FrontEndHelperMethods.Goodbye();
            
            Console.ReadKey();
        }
    }
}
