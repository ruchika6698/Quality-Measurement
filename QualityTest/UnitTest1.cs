using NUnit.Framework;
using QualityMeasurment;

namespace QualityTest
{
    public class Tests
    {
        Conversion converstion = new Conversion();
        Conversion converstion1 = new Conversion();
        /// <summary>
        ///UC1: TC-1.1: Test for comparision
        /// </summary>
        [Test]
        public void GivenInchesAndFeets_CompareEquals_ReturnFeet()
        {
            double Feet = converstion.Measure("3");
            Assert.AreEqual(36, Feet);
        }

        /// <summary>
        ///UC1: TC-1.2: Zero feet should return zero
        /// </summary>
        [Test]
        public void GivenZeroInch_whenZeroFeet_shouldRetrunEqual()
        {
            double inch = converstion.Measure("0");
            Assert.AreEqual(0, inch);
        }
        /// <summary>
        ///UC1: TC-1.3: Test of equality to check null input feet
        /// </summary>
        [Test]
        public void GivenZeroInch_WhenCheckNull_shouldReturnNullPointerException()
        {
            try
            {
                converstion.Measure(null);
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
            double quantity = converstion.Measure("0.0");
            double quantity1 = converstion1.Measure("0.0");
            bool areEqual = ReferenceEquals(quantity, quantity1);
            Assert.IsFalse(areEqual);
        }
        /// <summary>
        ///UC1: TC-1.5: Test of equality to check type
        /// </summary>
        [Test]
        public void GivenType_whenCheckType_ShouldReturnTypenotmatch()
        {
            try
            {
                converstion.Measure("1");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(e.type, CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }
        /// <summary>
        ///UC1: TC-1.6: value check for equality type
        /// </summary>
        [Test]
        public void Given_Equality_Type_Feet_And_Should_Return_True()
        {
            bool equal = ReferenceEquals(converstion.GetType(), converstion1.GetType());
            Assert.IsTrue(equal);
        }
        /// <summary>
        ///UC1: TC-1.7: Test for comparision
        /// </summary>
        [Test]
        public void GivenFeetsAndInches_CompareEquals_ReturnInches()
        {
            double inch = converstion.InchMeasure("45");
            Assert.AreEqual(3.75, inch);
        }
        /// <summary>
        ///UC1: TC-1.8: Test of equality to check null input for inches
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenCheckNull_shouldReturnNullPointerException()
        {
            try
            {
                converstion.InchMeasure(null);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(e.type, CustomException.ExceptionType.INPUT_NULL);
            }
        }
    }
}