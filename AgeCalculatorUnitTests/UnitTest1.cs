using System;
using BirthdayCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeCalculatorUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly DateTime currentDateTime = DateTime.Parse("01/01/2020");

        private AgeCalculator ageCalc = new AgeCalculator(currentDateTime);

        /// <summary>
        /// Test Age Calculation - this unit test checks that CalculateAge returns
        /// the correct age (20) for the parameters given.
        /// </summary>
        [TestMethod]
        public void TestAgeCalculation_ReturnsCorrectAge()
        {
            //arrange
            string testDateOfBirthStr = "01/01/2000";

            //act
            var age = ageCalc.CalculateAge(testDateOfBirthStr);

            //assert
            Assert.AreEqual(age,20);
        }

        /// <summary>
        /// Test Age Calculation - this unit test checks that Calculate age THROWS AN EXCEPTION
        /// when the date (string) is not in the parsable format.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "Date of birth must be correct and in mm/dd/yyyy")]
        public void TestAgeCalculation_throwsExceptionIncorrectDateString()
        {
            //arrange
            string testBirthDatestr = "88/99/8888";

            //act
            var age = ageCalc.CalculateAge(testBirthDatestr);
        }
    }
}
