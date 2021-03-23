using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectTDDEx2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquare()
        {
            calcLib.Calculation objc = new calcLib.Calculation();
            int num1 = 25;
            int result = num1 * num1;
            Assert.AreEqual(result, objc.square(num1));
        }
        [TestMethod]
        public void TestCube()
        {
            calcLib.Calculation objc = new calcLib.Calculation();
            int num1 = 25;
            int result = num1 * num1 * num1;
            Assert.AreEqual(result, objc.cube(num1));
        }
        [TestMethod]
        public void TestSquareroot()
        {
            calcLib.Calculation objc = new calcLib.Calculation();
            int num1 = 25 ;
            int squareroot = (int)Math.Sqrt(num1);
            Assert.AreEqual(squareroot, objc.squareroot(num1));
        }
        
      
        }
    }

