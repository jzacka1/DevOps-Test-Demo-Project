using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOps_Test_Demo_Project.Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdding()
        {
            //Arrange
            DevOps_Test_Demo_Project.Calculator.Calculator calculator = new DevOps_Test_Demo_Project.Calculator.Calculator();

            // Act
            int integerResult = calculator.Add(4, 2);

            //Assert
            Assert.IsNotNull(integerResult); // Testing integers
            Assert.AreEqual(6, integerResult); 
        }

        [TestMethod]
        public void TestSubtracting()
        {
            //Arrange
            DevOps_Test_Demo_Project.Calculator.Calculator calculator = new DevOps_Test_Demo_Project.Calculator.Calculator();

            // Act
            int integerResult = calculator.Subtract(4, 2);

            //Assert
            Assert.IsNotNull(integerResult);
            Assert.AreEqual(2, integerResult); // Testing integers
        }

        [TestMethod]
        public void TestMultiplying()
        {
            //Arrange
            DevOps_Test_Demo_Project.Calculator.Calculator calculator = new DevOps_Test_Demo_Project.Calculator.Calculator();

            // Act
            int integerResult = calculator.Multiply(4, 2);

            //Assert
            Assert.IsNotNull(integerResult);
            Assert.AreEqual(8, integerResult); // Testing integers
        }

        [TestMethod]
        public void TestDividing()
        {
            //Arrange
            DevOps_Test_Demo_Project.Calculator.Calculator calculator = new DevOps_Test_Demo_Project.Calculator.Calculator();

            // Act
            int integerResult = calculator.Divide(4, 2);

            //Assert
            Assert.IsNotNull(integerResult);
            Assert.AreEqual(2, integerResult); // Testing integers
            Assert.AreEqual(0, calculator.Divide(5, 0));  //Divide by zero
        }
    }
}
