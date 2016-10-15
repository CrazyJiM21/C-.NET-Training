using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask1.Tests
{
    [TestClass()]
    public class Task1Tests
    {
        [TestMethod()]
        public void GetLinesFromFileTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCorrectCoordinatesTest()
        {
            string[] list = { "1234.124,123.1234", "124.1414,1234,143", "1234,134.123412.134,", "1234.134,1324.431" };
            List<String[]> coordinates = Task1.GetCorrectCoordinates(list);
            List<String[]> expectedArray = new List<string[]>();
            expectedArray.Add(new string[] { "1234.124", "123.1234" });
            expectedArray.Add(new string[] { "1234.134", "1324.431" });
            Assert.AreEqual(expectedArray, coordinates);
        }

    }
}