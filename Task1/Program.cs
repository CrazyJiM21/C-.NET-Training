using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibraryTask1;

namespace ConsoleApplication2
{
    class Program
    {

        static void WriteFormattedList(List<String[]> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("X: {0}, Y: {1}", list[i][0], list[i][1]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tTASK 1");
            Console.WriteLine();
            string[] lines;
            string fileName = "coordinates.txt";

            try
            {
                lines = Task1.GetLinesFromFile(fileName);
            }
            catch (Exception)
            {
                Console.WriteLine("File \"" + fileName.ToUpper() + "\" Not Found!");
                lines = null;
            }

            if (lines != null)
            {
                var coordinates = Task1.GetCorrectCoordinates(lines);
                WriteFormattedList(coordinates);
            }

            if (Task1.CountIncorrect != 0)
                Console.WriteLine("\nThere were {0} incorrect lines in your input file!", Task1.CountIncorrect);

            Console.ReadLine();

        }
    }
}
