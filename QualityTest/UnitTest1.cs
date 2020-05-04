using NUnit.Framework;
using QualityMeasurment;
using System;

namespace QualityTest
{
    public class Tests
    {
        Conversion converstion = new Conversion();
        /// <summary>
        ///UC1: TC-1.1: Test for comparision
        /// </summary>
        [Test]
        public void GivenInchesAndFeets_CompareEquals_ReturnFeet()
        {
            try
            {
                double Feet = converstion.Feetmeasure("3");
                Assert.AreEqual(36, Feet);
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        ///UC1: TC-1.2: Zero feet should return zero
        /// </summary>
        [Test]
        public void GivenZeroFeet_whenZeroFeet_shouldRetrunEqual()
        {
            double inch = converstion.Feetmeasure("0");
            Assert.AreEqual(0, inch);
        }
        /// <summary>
        ///UC1: TC-1.3: Test of equality to check null input 
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenCheckNull_shouldReturnNullPointerException()
        {
            try
            {
                converstion.Feetmeasure(null);
            }
            catch(CustomException e)
            {
                Assert.AreEqual(e.type, CustomException.ExceptionType.INPUT_NULL);
            }
        }
        /// <summary>
        ///UC1: TC-1.4: Test of equality to check reference should return false
        /// </summary>
        [Test]
        public void GivenRefType_whenCheckRef_ShouldReturnFalse()
        {
            try
            {
                double quantity = converstion.Feetmeasure("0.0");
                Conversion converstion1 = new Conversion();
                double quantity1 = converstion1.Feetmeasure("0.0");
                bool areEqual = ReferenceEquals(quantity, quantity1);
                Assert.IsFalse(areEqual);
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}