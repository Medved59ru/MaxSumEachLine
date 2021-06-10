using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxSum;
using System.Collections.Generic;

namespace FindMaxSumTest
{
    [TestClass]
    public class AllMethodTests
    {
        [TestMethod]
        public void CheckPathTest()
        {
            string path = @"C:\Users\afigi\Desktop\FoxMined\SourceCode\FindMaximum\FindMaxSum\test.txt";
            var result = FileReader.CheckThe(path);

            Assert.ReferenceEquals(path, result);
            Assert.AreEqual(@"C:\Users\afigi\Desktop\FoxMined\SourceCode\FindMaximum\FindMaxSum\test.txt", result);

        }

        [TestMethod]
        public void GetPathTest()
        {
            string[] agrs = { @"C:\Users\afigi\Desktop\FoxMined\SourceCode\FindMaximum\FindMaxSum\test.txt" };
            var result = FileReader.GetPath(agrs);

            Assert.ReferenceEquals(agrs[0], result);
            Assert.AreEqual(@"C:\Users\afigi\Desktop\FoxMined\SourceCode\FindMaximum\FindMaxSum\test.txt", result);
        }
        [TestMethod]
        public void GetDataFromFileTest()
        {
            string path = @"C:\Users\afigi\Desktop\FoxMined\SourceCode\FindMaximum\FindMaxSum\test.txt";
            var result = FileReader.GetDataFromFileBy(path);

            Assert.IsNotNull(result);
            Assert.AreEqual(result[0], @"C:\Users\afigi\Desktop\FoxMined\SourceCode\FindMaximum\FindMaxSum\test.txt");

        }

        [TestMethod]
        public void GetNumberTest()
        {
            string[] testArray = { "e,dknggx.pnfs", "1.2,1.3", "1.3,6.8", "5,6,6", "12.34,17,7"};
            List<int> testList = new List<int>();

            var result = FileParser.GetNumberOfMaxLineIn(testArray, testList);

            Assert.AreEqual(5, result);
            Assert.AreEqual(1, testList[0]);
        }

    }
}
