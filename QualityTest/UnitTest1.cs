///-----------------------------------------------------------------
///   Class:       Tests
///   Description: All Tests cases
///   Author:      Ruchika                   Date: 5/5/2020
///-----------------------------------------------------------------

using NUnit.Framework;
using QualityMeasurment;

namespace QualityTest
{
    public class Tests
    {
        Unitconversion converstion = new Unitconversion();
        Unitconversion converstion1 = new Unitconversion();
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
            Unitconversion converstion = new Unitconversion();
            double inch = converstion.Measure(Unitconversion.Unit.feet, "0");
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
                Unitconversion converstion = new Unitconversion();
                // give null value
                converstion.Measure(Unitconversion.Unit.feet, null);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Null", e.Message);
            }
        }
        /// <summary>
        ///UC1: TC-1.4: Test of equality to check reference should return false
        /// </summary>
        [Test]
        public void GivenRefType_whenCheckRef_ShouldReturnFalse()
        {
            double quantity = converstion.Measure(Unitconversion.Unit.feet, "0.0");
            double quantity1 = converstion1.Measure(Unitconversion.Unit.feet, "0.0");
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
                converstion.Measure(Unitconversion.Unit.feet, "");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Type Not Match", e.Message);
            }
        }
        /// <summary>
        ///UC1: TC-1.6: value check for equality type
        /// </summary>
        [Test]
        public void Given_Equality_Type_Feet_And_Should_Return_True()
        {
            bool equalitytype = ReferenceEquals(converstion.GetType(), converstion1.GetType());
            Assert.IsTrue(equalitytype);
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
                converstion.Measure(Unitconversion.Unit.inch, null);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Null", e.Message);
            }
        }
        /// <summary>
        ///UC1: TC-1.9: Test of equality to check reference should return false for inches
        /// </summary>
        [Test]
        public void GivenInchesRefType_whenCheckRef_ShouldReturnFalse()
        {
            double quantity = converstion.Measure(Unitconversion.Unit.inch, "0.0");
            double quantity1 = converstion.Measure(Unitconversion.Unit.inch, "0.0");
            bool equality = ReferenceEquals(quantity, quantity1);
            Assert.IsFalse(equality);
        }
        /// <summary>
        ///UC1: TC-1.10: Test of equality to check type for Inches
        /// </summary>
        [Test]
        public void GivenTypeforInches_whenCheckType_ShouldReturnTypenotmatch()
        {
            try
            {
                converstion.Measure(Unitconversion.Unit.inch, "");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Type Not Match", e.Message);
            }
        }
        /// <summary>
        ///UC1: TC-1.11: value check for equality type
        /// </summary>
        [Test]
        public void GivenInches_Equality_Type_FeetAnd_ShouldReturnTrue()
        {
            bool equalitytype = ReferenceEquals(converstion.GetType(), converstion1.GetType());
            Assert.IsTrue(equalitytype);
        }
        /// <summary>
        ///UC1: TC-1.12: 0 inch and 0 feet should return equal
        /// </summary>
        [Test]
        public void GivenInchesandFeet_Whenbothzero_ShouldReturnequal()
        {
            //for 0 inch
            double Feet = converstion.GetFeet(0);
            //for o feet
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
        ///UC1: TC-1.15: 1 feet is equal to one inch
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
        ///UC2: TC-1.18: 1 feet not equal to 1 yard
        /// </summary>
        [Test]
        public void GivenYardandFeet_Whenvalue1_ShouldReturnnotequalYard()
        {
            double Yard = converstion.GetYard(1);
            Assert.AreNotEqual(1, Yard);
        }
        /// <summary>
        ///UC2: TC-1.19: 1 inch not equal to 1 yard
        /// </summary>
        [Test]
        public void GivenInchandYard_Whenvalue1_ShouldReturnnotequalYard()
        {
            double Inch = converstion.GetInch(12);
            double Yard = converstion.GetYard(0.33);
            Assert.AreNotEqual(Inch, Yard);
        }
        /// <summary>
        ///UC2: TC-1.20: 1 Yard is equal to 36 inch
        /// </summary>
        [Test]
        public void GivenInchandYard_WhenvalueisInch_ShouldReturnequalYard()
        {
            //for 1 yard
            double Yard = converstion.GetYard(1);
            //for 36 inch
            double Inch = converstion.GetInch(36);
            Assert.AreEqual(Yard, Inch);
        }
        /// <summary>
        ///UC2: TC-1.21: 36 inch is equal to 1 yard
        /// </summary>
        [Test]
        public void GivenInchandYard_WhenvalueisYard_ShouldReturnequalInch()
        {
            //for 36 inch
            double Inch = converstion.GetInch(36);
            //for 1 yard
            double Yard = converstion.GetYard(1);
            Assert.AreEqual(Inch,Yard);
        }
        /// <summary>
        ///UC3: 2 inches is equal to 5 centimeter
        /// </summary>
        [Test]
        public void GivenInchandcentimeter_WhenvalueInch_ShouldReturnequalcentimeter()
        {
            double Yard = converstion.GetCentimeter(2);
            Assert.AreEqual(5, Yard);
        }
        /// <summary>
        ///UC4:TC1.1: add 2 inch and 2 inch length and retuen 4 inches
        /// </summary>
        [Test]
        public void Given2inch_WhenvalueInch_ShouldReturnequalinch()
        {
            // for 2 inch=24 feet
            double value1 = converstion.Measure(Unitconversion.Unit.inch,"24");
            double value2 = converstion.Measure(Unitconversion.Unit.inch,"24");
            double TotalInch = (value1 + value2);
            Assert.AreEqual(4,TotalInch);
        }
        /// <summary>
        ///UC4: TC1.2: add 1 feet and 2 inch length and retuen in 14 inches
        /// </summary>
        [Test]
        public void GivenFeetinch_WhenvalueInch_ShouldReturnequalInch()
        {
            // value1 for 1 feet
            double value1 = converstion.GetFeet(1);
            // value2 for 2 inch=24 feet
            double value2 = converstion.GetInch(24);
            double TotalInch = (value1 + value2);
            Assert.AreEqual(14, TotalInch);
        }
        /// <summary>
        ///UC4: TC1.3: add 1 feet and 1 feet length and retuen in 24 inches
        /// </summary>
        [Test]
        public void GivenFeet_WhenvalueFeet_ShouldReturnequalInch()
        {
            // value for 1 feet
            double value1 = converstion.GetFeet(1);
            double value2 = converstion.GetFeet(1);
            double TotalInch = (value1 + value2);
            Assert.AreEqual(24, TotalInch);
        }
        /// <summary>
        ///UC4: TC1.4: add 2 inch and 2.5 cm length and retuen in 3 inches
        /// </summary>
        [Test]
        public void GivenInchCentimter_WhenvalueFeet_ShouldReturnequalInch()
        {
            // value1 for 2 inch
            double value1 = converstion.GetInch(24);
            // value1 for 2.5 cm
            double value2 = converstion.CentimeterToInch(2.5);
            double TotalInch = (value1 + value2);
            Assert.AreEqual(3, TotalInch);
        }
        /// <summary>
        ///UC5: 1 gollan to litre conversion 
        /// </summary>
        [Test]
        public void Givengollan_Whenvaluegollan_ShouldReturnequallitre()
        {
            // check for 1 Gallon=3.78 litrs 
            double gallan = converstion.GallonToLitre(1);
            Assert.AreEqual(3.78, gallan);
            // check for 1 litre=1000 ml 
            double litre = converstion.LiterToMilliliterAndKgToGramsAndToneToKgs(1);
            Assert.AreEqual(1000, litre);
        }
        /// <summary>
        ///UC6: Volume in litres
        /// </summary>
        [Test]
        public void GivengollanandLitres_WhenAddVolume_ShouldReturnequallitre()
        {
            //value1= check for 1 Gallon=3.78 litrs 
            double value1 = converstion.GallonToLitre(1);
            double value2 = 3.78;
            double TotalGallonLitres = (value1 + value2);
            Assert.AreEqual(7.56, TotalGallonLitres);
            //Check for 1 litre and 1000 ml
            double litre = 1;
            double ml = converstion.MilliliterToLiterandtonetoKg(1000);
            double TotalLitres = (litre + ml);
            Assert.AreEqual(2, TotalLitres);
        }
        /// <summary>
        ///UC7:Add weight in grams
        /// </summary>
        [Test]
        public void Givenweight_WhenAddingrams_ShouldReturnequalkg()
        {
            //check for 1 tone
            double Tone = converstion.MilliliterToLiterandtonetoKg(1000);
            // check for 1 kg
            double kg = converstion.LiterToMilliliterAndKgToGramsAndToneToKgs(1);
            double Total = (Tone + kg);
            Assert.AreEqual(1001, Total);
        }
        /// <summary>
        ///UC8: convert degree fareinhit to celcius
        /// </summary>
        [Test]
        public void GivendegreeFarenhit_WhenTemperature_ShouldReturnequalCelcius()
        {
            double celcius = converstion.FarenhitToCelcius(212);
            Assert.AreEqual(100, celcius);
        }
    }
}