using NUnit.Framework;
using QualityMeasurment;

namespace QualityTest
{
    public class Tests
    {
        /// <summary>
        ///UC1: TC-1.1: Zero feet should return zero
        /// </summary>
        [Test]
        public void GivenZeroFeet_whenZeroFeet_shouldRetrunEqual()
        {
            Conversion converstion = new Conversion();
            Assert.AreEqual(0, converstion.Feetmeasure(0));
        }
    }
}