using NUnit.Framework;
using QualityMeasurment;

namespace QualityTest
{
    public class Tests
    {
        Conversion converstion = new Conversion();
        /// <summary>
        ///UC1: TC-1.1: Zero feet should return zero
        /// </summary>
        [Test]
        public void GivenZeroFeet_whenZeroFeet_shouldRetrunEqual()
        {
            double inch = converstion.Feetmeasure("0");
            Assert.AreEqual(0, inch);
        }
        /// <summary>
        ///UC1: TC-1.2: Test of equality to check null input 
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenNull_shouldReturnNullPointerException()
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