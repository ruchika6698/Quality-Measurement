///-----------------------------------------------------------------
///   Class:       Tests
///   Description: All Tests cases
///   Author:      Ruchika                   Date: 5/5/2020
///-----------------------------------------------------------------

using NUnit.Framework;
using QualityMeasurment;
using QuantityMeasurment;

namespace QualityTest
{
    public class Tests
    {
        Conversionlength conversionlength = new Conversionlength();
        Conversionlength converstion1 = new Conversionlength();
        Conversionvolume convertvolume = new Conversionvolume();
        Coversionweight convertweight = new Coversionweight();
        Conversiontemprature converttemprature = new Conversiontemprature();

        /// <summary>
        ///UC1: TC-1.1: Test for comparision
        /// </summary>
        [Test]
        public void GivenInchesAndFeets_CompareEquals_ReturnFeet()
        {
            try
            {
                double Feet = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "3");
                Assert.AreEqual(36, Feet);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.2: Zero feet should return zero
        /// </summary>
        [Test]
        public void GivenZeroInch_whenZeroFeet_shouldRetrunEqual()
        {
            try
            {
                double inch = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "0");
                Assert.AreEqual(0, inch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.3: Test of equality to check null input feet
        /// </summary>
        [Test]
        public void GivenZeroInch_WhenCheckNull_shouldReturnNullPointerException()
        {
            try
            {
                // give null value
                conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, null);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INPUT_NULL, e.type);
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
                double quantity = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "0.0");
                double quantity1 = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "0.0");
                bool areEqual = ReferenceEquals(quantity, quantity1);
                Assert.IsFalse(areEqual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.5: Test of equality to check type
        /// </summary>
        [Test]
        public void GivenType_whenCheckType_ShouldReturnTypenotmatch()
        {
            try
            {
                conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.TYPE_NOT_MATCH, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.6: value check for equality type
        /// </summary>
        [Test]
        public void Given_Equality_Type_Feet_And_Should_Return_True()
        {
            try
            {
                bool equalitytype = ReferenceEquals(conversionlength.GetType(), converstion1.GetType());
                Assert.IsTrue(equalitytype);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.7: Test for comparision
        /// </summary>
        [Test]
        public void GivenFeetsAndInches_CompareEquals_ReturnInches()
        {
            try
            {
                double inch = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "45"); ;
                Assert.AreEqual(3.75, inch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.8: Test of equality to check null input for inches
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenCheckNull_shouldReturnNullPointerException()
        {
            try
            {
                conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, null);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INPUT_NULL, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.9: Test of equality to check reference should return false for inches
        /// </summary>
        [Test]
        public void GivenInchesRefType_whenCheckRef_ShouldReturnFalse()
        {
            try
            {
                double quantity = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "0.0");
                double quantity1 = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "0.0");
                bool equality = ReferenceEquals(quantity, quantity1);
                Assert.IsFalse(equality);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.10: Test of equality to check type for Inches
        /// </summary>
        [Test]
        public void GivenTypeforInches_whenCheckType_ShouldReturnTypenotmatch()
        {
            try
            {
                conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.TYPE_NOT_MATCH, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.11: value check for equality type
        /// </summary>
        [Test]
        public void GivenInches_Equality_Type_FeetAnd_ShouldReturnTrue()
        {
            try
            {
                bool equalitytype = ReferenceEquals(conversionlength.GetType(), converstion1.GetType());
                Assert.IsTrue(equalitytype);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.12: 0 inch and 0 feet should return equal
        /// </summary>
        [Test]
        public void GivenInchesandFeet_Whenbothzero_ShouldReturnequal()
        {
            try
            {
                //for 0 inch
                double Feet = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "0.0");
                //for 0 feet
                double inch = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "0.0"); ;
                Assert.AreEqual(Feet, inch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.13: 1 feet not equal to one inch
        /// </summary>
        [Test]
        public void GivenFeetnotInch_Whenvalue1_ShouldReturnequal()
        {
            try
            {
                double Feet = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "1");
                double Inch = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "1");
                Assert.AreNotEqual(Feet, Inch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.14: 1 feet not equal to one inch
        /// </summary>
        [Test]
        public void GivenInchnotFeet_Whenvalue1_ShouldReturnequal()
        {
            try
            {
                double Feet = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "1");
                double Inch = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "1");
                Assert.AreNotEqual(Inch, Feet);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.15: 1 feet is equal to 1 inch
        /// </summary>
        [Test]
        public void GivenFeet_WhenInch_ShouldReturnInInches()
        {
            try
            {
                double Feet = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "1");
                Assert.AreEqual(12, Feet);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC1: TC-1.16: 12 inch is equal to 1 feet
        /// </summary>
        [Test]
        public void GivenInch_WhenConvertFeet_ShouldReturnInFeet()
        {
            try
            {
                double Inch = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "12");
                Assert.AreEqual(1, Inch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC2: TC-1.17:3 feet is equal to one yard
        /// </summary>
        [Test]
        public void GivenFeet_whenvertFeet_ShouldReturnInYard()
        {
            try
            {
                double Yard = conversionlength.Measure(Conversionlength.Unit.YARD_TO_FEET, "1");
                Assert.AreEqual(3, Yard);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC2: TC-1.18: 1 feet not equal to 1 yard
        /// </summary>
        [Test]
        public void GivenYardandFeet_Whenvalue1_ShouldReturnnotequalYard()
        {
            try
            {
                double Yard = conversionlength.Measure(Conversionlength.Unit.YARD_TO_FEET, "1");
                Assert.AreNotEqual(1, Yard);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC2: TC-1.19: 1 inch not equal to 1 yard
        /// </summary>
        [Test]
        public void GivenInchandYard_Whenvalue1_ShouldReturnnotequalYard()
        {
            try
            {
                double Inch = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "1");
                double Yard = conversionlength.Measure(Conversionlength.Unit.YARD_TO_FEET, "1");
                Assert.AreNotEqual(Inch, Yard);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC2: TC-1.20: 1 Yard is equal to 36 inch
        /// </summary>
        [Test]
        public void GivenInchandYard_WhenvalueisInch_ShouldReturnequalYard()
        {
            try
            {
                //for 1 yard
                double Yard = conversionlength.Measure(Conversionlength.Unit.YARD_TO_FEET, "1");
                //for 36 inch
                double Inch = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "36");
                Assert.AreEqual(Yard, Inch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC2: TC-1.21: 36 inch is equal to 1 yard
        /// </summary>
        [Test]
        public void GivenInchandYard_WhenvalueisYard_ShouldReturnequalInch()
        {
            try
            {
                //for 36 inch
                double Inch = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "36");
                //for 1 yard
                double Yard = conversionlength.Measure(Conversionlength.Unit.YARD_TO_FEET, "1");
                Assert.AreEqual(Inch, Yard);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC3: 2 inches is equal to 5 centimeter
        /// </summary>
        [Test]
        public void GivenInchandcentimeter_WhenvalueInch_ShouldReturnequalcentimeter()
        {
            try
            {
                double Cm = conversionlength.Measure(Conversionlength.Unit.INCH_TO_CENTIMETER, "2");
                Assert.AreEqual(5, Cm);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC4:TC1.1: add 2 inch and 2 inch length and retuen 4 inches
        /// </summary>
        [Test]
        public void Given2inch_WhenvalueInch_ShouldReturnequalinch()
        {
            try
            {
                // for 2 inch=24 feet
                double value1 = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "24");
                double value2 = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "24");
                double TotalInch = (value1 + value2);
                Assert.AreEqual(4, TotalInch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC4: TC1.2: add 1 feet and 2 inch length and retuen in 14 inches
        /// </summary>
        [Test]
        public void GivenFeetinch_WhenvalueInch_ShouldReturnequalInch()
        {
            try
            {
                // value1 for 1 feet
                double value1 = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "1");
                // value2 for 2 inch=24 feet
                double value2 = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "24");
                double TotalInch = (value1 + value2);
                Assert.AreEqual(14, TotalInch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC4: TC1.3: add 1 feet and 1 feet length and retuen in 24 inches
        /// </summary>
        [Test]
        public void GivenFeet_WhenvalueFeet_ShouldReturnequalInch()
        {
            try
            {
                // value for 1 feet
                double value1 = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "1");
                double value2 = conversionlength.Measure(Conversionlength.Unit.FEET_TO_INCH, "1");
                double TotalInch = (value1 + value2);
                Assert.AreEqual(24, TotalInch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC4: TC1.4: add 2 inch and 2.5 cm length and retuen in 3 inches
        /// </summary>
        [Test]
        public void GivenInchCentimter_WhenvalueFeet_ShouldReturnequalInch()
        {
            try
            {
                // value1 for 2 inch
                double value1 = conversionlength.Measure(Conversionlength.Unit.INCH_TO_FEET, "24");
                // value1 for 2.5 cm
                double value2 = conversionlength.Measure(Conversionlength.Unit.CENTIMETER_TO_INCH, "2.5");
                double TotalInch = (value1 + value2);
                Assert.AreEqual(3, TotalInch);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC5: 1 gollan to litre conversion 
        /// </summary>
        [Test]
        public void Givengollan_Whenvaluegollan_ShouldReturnequallitre()
        {
            try
            {
                // check for 1 Gallon=3.78 litrs 
                double gallon = convertvolume.Comparevolume(Conversionvolume.Volume.GALLON_TO_LITRE, 1);
                Assert.AreEqual(3.78, gallon);
                // check for 1 litre=1000 ml 
                double litre = convertvolume.Comparevolume(Conversionvolume.Volume.LITRE_TO_MILLILITER, 1);
                Assert.AreEqual(1000, litre);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC6: Volume in litres
        /// </summary>
        [Test]
        public void GivengollanandLitres_WhenAddVolume_ShouldReturnequallitre()
        {
            try
            {
                //value1= check for 1 Gallon=3.78 litrs 
                double value1 = convertvolume.Comparevolume(Conversionvolume.Volume.GALLON_TO_LITRE, 1);
                double value2 = 3.78;
                double TotalGallonLitres = (value1 + value2);
                Assert.AreEqual(7.56, TotalGallonLitres);
                //Check for 1 litre and 1000 ml
                double litre = 1;
                double ml = convertvolume.Comparevolume(Conversionvolume.Volume.MILILITRE_TO_LITER, 1000);
                double TotalLitres = (litre + ml);
                Assert.AreEqual(2, TotalLitres);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC7:Add weight in grams
        /// </summary>
        [Test]
        public void Givenweight_WhenAddingrams_ShouldReturnequalkg()
        {
            try
            {
                //check for 1 tone
                double Tone = convertweight.CompareWeight(Coversionweight.Weight.TONNE_TO_KILOGRAM, 1);
                // check for 1 kg
                double kg = convertweight.CompareWeight(Coversionweight.Weight.GRAM_TO_KILOGRAM, 1000);
                double Total = (Tone + kg);
                Assert.AreEqual(1001, Total);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
        /// <summary>
        ///UC8: convert degree fareinhit to celcius
        /// </summary>
        [Test]
        public void GivendegreeFarenhit_WhenTemperature_ShouldReturnequalCelcius()
        {
            try
            {
                double celcius = converttemprature.FarenhitToCelcius(212);
                Assert.AreEqual(100, celcius);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.ExceptionType.INVALID_CHOICE, e.type);
            }
        }
    }
}