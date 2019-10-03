using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using Exercise4b;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);          
        }
        [TestMethod]
        public void TestAbs()
        {
             int result6 = Program.Abs(-6);
             Assert.AreEqual(6,result6);
        }
        [TestMethod]
        public void TestCeil()
        {
            int rs = Program.Ceil(4.6F);
            Assert.AreEqual(5, rs);

            int rs1 = Program.Ceil(-2.3F);
            Assert.AreEqual(-2, rs1);

            int rs2 = Program.Ceil(3);
            Assert.AreEqual(3, rs2);

        }
        [TestMethod]
        public void TestFloor()
        {
            int rs = Program.Floor(7.7F);
            Assert.AreEqual(7, rs);
        }
        [TestMethod]
        public void TestCube()
        {
            int rs = Program.Cube(-10);
            Assert.AreEqual(-1000, rs);
        }
        [TestMethod]
        public void TestIsEven()
        {
            bool rs = Program.IsEven(4);
            Assert.AreEqual(true, rs);
        }
        [TestMethod]
        public void TestIsPrime()
        {
            bool rs = Program.IsPrime(7);
            Assert.AreEqual(true, rs);
        }
        [TestMethod]
        public void TestPow()
        {
            int rs = Program.Pow(2,3);
            Assert.AreEqual(8, rs);
        }
        [TestMethod]
        public void TestSquare()
        {
            int rs = Program.Square(4);
            Assert.AreEqual(16, rs);
        }
        [TestMethod]
        public void TestFactorial()
        {
            long rs = Program.Factorial(20L);
            Assert.AreEqual(109641728, rs);
        }
        [TestMethod]
        public void TestIsContrain5()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool rs1 = Program2.IsContrain5(arr1);
            Assert.AreEqual(true, rs1);

            int[] arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool rs2 = Program2.IsContrain5(arr2);
            Assert.AreEqual(false, rs2);
        }
        [TestMethod]
        public void TestIsContrain5or6()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool rs1 = Program2.IsContrain5or6(arr1);
            Assert.AreEqual(true, rs1);

            int[] arr2 = new int[] { 1, 2, 3, 4, 7 };
            bool rs2 = Program2.IsContrain5or6(arr2);
            Assert.AreEqual(false, rs2);

            int[] arr3 = new int[] { 1, 2, 3, 4 };
            bool rs3 = Program2.IsContrain5or6(arr2);
            Assert.AreEqual(false, rs3);
        }
        [TestMethod]
        public void TestIsContrain5and6()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool rs1 = Program2.IsContrain5and6(arr1);
            Assert.AreEqual(false, rs1);

            int[] arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool rs2 = Program2.IsContrain5and6(arr2);
            Assert.AreEqual(false, rs2);

            int[] arr3 = new int[] { 1, 2, 3, 4, 5, 6 };
            bool rs3 = Program2.IsContrain5and6(arr3);
            Assert.AreEqual(true, rs3);

            int[] arr4 = new int[] { 1, 2, 3, 4 };
            bool rs4 = Program2.IsContrain5and6(arr4);
            Assert.AreEqual(false, rs4);
        }
        [TestMethod]
        public void TestCount5()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int rs1 = Program2.count5(arr1);
            Assert.AreEqual(1, rs1);

            int[] arr2 = new int[] { 1, 2, 3, 4 };
            int rs2 = Program2.count5(arr2);
            Assert.AreEqual(0, rs2);

            int[] arr3 = new int[] { 1, 2, 5, 5, 5 };
            int rs3 = Program2.count5(arr3);
            Assert.AreEqual(3, rs3);
        }
        [TestMethod]
        public void TestCount5or6()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int rs1 = Program2.count5or6(arr1);
            Assert.AreEqual(1, rs1);

            int[] arr2 = new int[] { 1, 2, 3, 4 };
            int rs2 = Program2.count5or6(arr2);
            Assert.AreEqual(0, rs2);

            int[] arr3 = new int[] { 1, 2, 5, 6, 5 };
            int rs3 = Program2.count5or6(arr3);
            Assert.AreEqual(3, rs3);
        }
        [TestMethod]
        public void TestSum()
        {
            int[] arr1 = new int[0];
            int rs1 = Program2.Sum(arr1);
            Assert.AreEqual(0, rs1);

            int[] arr2 = new int[]{1,2,3,4,-1,5};
            int rs2 = Program2.Sum(arr2);
            Assert.AreEqual(14, rs2);
        }
    }
}
