using NUnit.Framework;
using QualityMeasurment;

namespace QualityTest
{
    public class Tests
    {
        Conversion converstion = new Conversion();
        /// <summary>
        ///UC1: TC-1.1: Test for comparision
        /// </summary>
        [Test]
        public void GivenInchesAndFeets_CompareEquals_ReturnBool()
        {
            try
            {
                double inch = converstion.Feetmeasure("3");
                Assert.AreEqual(36, inch);
            }
            catch (CustomException e)
            {
                System.Console.WriteLine(e.Message);
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
    }
}