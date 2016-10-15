using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryTask1
{
    /// <summary>
    /// The assembly of my static methods
    /// </summary>
    public class Task1
    {
        /// <summary>
        /// Integer variable counting incorrect lines in input file.
        /// </summary>
        private static int countIncorrect = 0;
        /// <summary>
        /// Property to access <code>countIncorrect</code> variable
        /// </summary>
        public static int CountIncorrect { get { return countIncorrect; } set { countIncorrect = value; } }

        /// <summary>
        /// Gets array of strings from the input file.
        /// </summary>
        /// <param name="fileName">A string path to input file</param>
        /// <returns>Array of strings from file</returns>
        public static string[] GetLinesFromFile(string fileName)
        {
            return File.ReadAllLines(fileName);
        }

        private static bool CompareWithPattern(string s)
        {
            string pattern = @"\d+[.]\d+[,]\d+[.]\d+";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(s)) return true;
            else return false;
        }

        /// <summary>
        /// Gets list of correct coordinates from the string array according to the specified pattern.
        /// </summary>
        /// <param name="list">An array of strings where we want to find coordinates</param>
        /// <returns>The list of strings with coordinates found in param array</returns>
        public static List<String[]> GetCorrectCoordinates(string[] list)
        {
            var coordinates = new List<String[]>();

            for (int i = 0; i < list.Length; i++)
            {
                if (CompareWithPattern(list[i]))
                {
                    coordinates.Add(list[i].Split(','));
                }
                else CountIncorrect++;
            }
            return coordinates;
        }
    }
}
