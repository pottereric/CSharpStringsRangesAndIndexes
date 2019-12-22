using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpStringsRangesAndIndexesUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTheFirstEightCharactersOfAString()
        {
            string fileName = "myTestFileName.txt";
            string firstEight = fileName[0..8];
            Assert.AreEqual("myTestFi", firstEight);
        }

        [TestMethod]
        public void GetTheFirstEightCharactersOfAString_Shorter()
        {
            string fileName = "myTestFileName.txt";
            string firstEight = fileName[..8];
            Assert.AreEqual("myTestFi", firstEight);
        }

        [TestMethod]
        public void GetTheFileNameWithoutTheExtension()
        {
            string fileName = "myTestFileName.txt";
            string fileNameWithExtension = fileName[0..^4];
            Assert.AreEqual("myTestFileName", fileNameWithExtension);
        }

        [TestMethod]
        public void GetTheExtension()
        {
            string fileName = "myTestFileName.txt";
            string extension = fileName[^3..^0];
            Assert.AreEqual("txt", extension);
        }

        [TestMethod]
        public void GetTheExtension_Shorter()
        {
            string fileName = "myTestFileName.txt";
            string extension = fileName[^3..];
            Assert.AreEqual("txt", extension);
        }

        [TestMethod]
        public void GetTextInsideOfBrackets()
        {
            string data = "{importantData}";
            string innerData = data[1..^1];
            Assert.AreEqual("importantData", innerData);
        }
    }
}
