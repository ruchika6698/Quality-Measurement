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
            double Feet = converstion.GetFeet(3);
            Assert.AreEqual(36, Feet);
        }
        /// <summary>
        ///UC1: TC-1.2: Zero feet should return zero
        /// </summary>
        [Test]
        public void GivenZeroInch_whenZeroFeet_shouldRetrunEqual()
        {
            Conversion converstion = new Conversion();
            double inch = converstion.Measure(Conversion.Unit.feet, "0");
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
                Conversion converstion = new Conversion();
                converstion.Measure(Conversion.Unit.feet, null);
            }
            catch (CustomException e)
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
            double quantity = converstion.Measure(Conversion.Unit.feet, "0.0");
            double quantity1 = converstion1.Measure(Conversion.Unit.feet, "0.0");
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
                converstion.Measure(Conversion.Unit.feet, "1");
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
            double inch = converstion.GetInch(45);
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
                converstion.Measure(Conversion.Unit.inch, null);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(e.type, CustomException.ExceptionType.INPUT_NULL);
            }
        }
        /// <summary>
        ///UC1: TC-1.9: Test of equality to check reference should return false for inches
        /// </summary>
        [Test]
        public void GivenInchesRefType_whenCheckRef_ShouldReturnFalse()
        {
            double quantity = converstion.Measure(Conversion.Unit.inch, "0.0");
            double quantity1 = converstion.Measure(Conversion.Unit.inch, "0.0");
            bool areEqual = ReferenceEquals(quantity, quantity1);
            Assert.IsFalse(areEqual);
        }
        /// <summary>
        ///UC1: TC-1.10: Test of equality to check type for Inches
        /// </summary>
        [Test]
        public void GivenTypeforInches_whenCheckType_ShouldReturnTypenotmatch()
        {
            try
            {
                converstion.Measure(Conversion.Unit.inch, "1");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(e.type, CustomException.ExceptionType.TYPE_NOT_MATCH);
            }
        }
        /// <summary>
        ///UC1: TC-1.11: value check for equality type
        /// </summary>
        [Test]
        public void GivenInches_Equality_Type_FeetAnd_ShouldReturnTrue()
        {
            bool equal = ReferenceEquals(converstion.GetType(), converstion1.GetType());
            Assert.IsTrue(equal);
        }
        /// <summary>
        ///UC1: TC-1.12: 0 inch and 0 feet should return equal
        /// </summary>
        [Test]
        public void GivenInchesandFeet_Whenbothzero_ShouldReturnequal()
        {
            double Feet = converstion.GetFeet(0);
            double inch = converstion.GetInch(0);
            Assert.AreEqual(Feet, inch);
        }
        /// <summary>
        ///UC1: TC-1.13: 1 feet not equal to one inch
        /// </summary>
        [Test]
        public void GivenFeetnotInch_Whenvalue1_ShouldReturnequal()
        {
            double Feet = converstion.GetFeet(1);
            Assert.AreNotEqual(1, Feet);
        }
        /// <summary>
        ///UC1: TC-1.14: 1 feet not equal to one inch
        /// </summary>
        [Test]
        public void GivenInchnotFeet_Whenvalue1_ShouldReturnequal()
        {
            double Feet = converstion.GetInch(1);
            Assert.AreNotEqual(1, Feet);
        }
        /// <summary>
        ///UC1: TC-1.15: 1 feet not equal to one inch
        /// </summary>
        [Test]
        public void GivenFeet_WhenInch_ShouldReturnInInches()
        {
            double Feet = converstion.GetFeet(1);
            Assert.AreEqual(12, Feet);
        }
        /// <summary>
        ///UC1: TC-1.16: 12 inch is equal to 1 feet
        /// </summary>
        [Test]
        public void GivenInch_WhenConvertFeet_ShouldReturnInFeet()
        {
            double Inch = converstion.GetInch(12);
            Assert.AreEqual(1,Inch);
        }
        /// <summary>
        ///UC2: TC-1.17:3 feet is equal to one yard
        /// </summary>
        [Test]
        public void GivenFeet_whenvertFeet_ShouldReturnInYard()
        {
            double Yard = converstion.GetYard(1);
            Assert.AreEqual(3, Yard);
        }
        /// <summary>
        ///UC1: TC-1.18: 1 feet not equal to 1 yard
        /// </summary>
        [Test]
        public void GivenYardandFeet_Whenvalue1_ShouldReturnnotequalYard()
        {
            double Yard = converstion.GetYard(1);
            Assert.AreNotEqual(1, Yard);
        }
        /// <summary>
        ///UC1: TC-1.19: 1 inch not equal to 1 yard
        /// </summary>
        [Test]
        public void GivenInchandYard_Whenvalue1_ShouldReturnnotequalYard()
        {
            double Inch = converstion.GetInch(12);
            double Yard = converstion.GetYard(0.33);
            Assert.AreNotEqual(Inch, Yard);
        }
        /// <summary>
        ///UC1: TC-1.19: 1 Yard is equal to 36 inch
        /// </summary>
        [Test]
        public void GivenInchandYard_WhenvalueisInch_ShouldReturnequalYard()
        {
            double Yard = converstion.GetYard(12);
            Assert.AreEqual(36, Yard);
        }
    }
}