using System;

namespace QualityMeasurment
{
    public class Conversion
    {
        /// <summary>
        /// Variable Declaration
        /// </summary>
        public double feet;
        private double inch;
        private double yard;
        private double centimeter;

        public enum Unit { feet, inch, yard,centimeter }
        /// <summary>
        /// Main Method
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quality Measurment problem");

        }
        /// <summary>
        /// Method for measurement
        /// </summary>
        /// <param name="input"> input </param>
        /// <param name="option"> input </param>
        /// <returns> Calculate Measurement </returns>
        public double Measure(Unit option, string input)
        {
            //if input type is not equal to null
            if (input != null)
            {
                // Calculate feet value
                if (double.TryParse(input, out inch))
                {
                    // Switch case for Feet ,Inches,yard,Centimeter
                    switch (option)
                    {
                        case Unit.feet:
                            return GetFeet(feet);
                        case Unit.inch:
                            return GetInch(inch);
                        case Unit.yard:
                            return GetYard(yard);
                        case Unit.centimeter:
                            return GetCentimeter(centimeter);
                    };
                }
                else
                {
                    //else throw Type Not Match exception
                    throw new CustomException("Type Not Match", CustomException.ExceptionType.TYPE_NOT_MATCH);
                }
            }
            else
            {
                //else throw Null exception
                throw new CustomException("Null", CustomException.ExceptionType.INPUT_NULL);
            }
            return feet;
        }

        /// <summary>
        /// Method for Feet
        /// </summary>
        /// <param name="inch"> input inch </param>
        /// <returns> Calculate Feet </returns>
        public double GetFeet(double inch)
        {
            return feet =inch * 12;
        }

        /// <summary>
        /// Method for inch
        /// </summary>
        /// <param name="feet"> input feet </param>
        /// <returns> Calculate Inch </returns>
        public double GetInch(double feet)
        {
            return inch =feet / 12;
        }

        /// <summary>
        /// Method for yard
        /// </summary>
        /// <param name="feet"> input feet </param>
        /// <returns> Calculate Yard </returns>
        public double GetYard(double feet)
        {
            return yard = feet * 3;
        }

        /// <summary>
        /// Method for yard
        /// </summary>
        /// <param name="inch"> input feet </param>
        /// <returns> Calculate Centimeter </returns>
        public double GetCentimeter(double inch)
        {
            return centimeter = inch * 2.5;
        }
        public double CentimeterToInch(double centimeter)
        {
            return inch = centimeter / 2.5;
        }
        /// <summary>
        ///  Method For Gallon
        /// </summary>
        /// <param name="gallon"> input gallon </param>
        /// <returns> Calculate GallonToLitre </returns>
        public double GallonToLitre(double gallon)
        {
            double litre = 3.78;
            return litre * gallon;
        }
        /// <summary>
        ///  Method For Liter , Kg And Tonne
        /// </summary>
        /// <param name="weights"> input weights </param>
        /// <returns> Calculate Liter To Milliliter,kg,gram.tone </returns>

        public double LiterToMilliliterAndKgToGramsAndToneToKgs(double weights)
        {
            double mlAndKgAndgrams = 1000;
            return mlAndKgAndgrams * weights;
        }
        /// <summary>
        ///  Method For Gallon
        /// </summary>
        /// <param name="milliliter"> input milliliter</param>
        /// <returns> Milimetre to litre tone to kg Conversion </returns>
        public double MilliliterToLiterandtonetoKg(double milliliter)
        {
            double liter = 1000;
            return liter / milliliter;
        }
        /// <summary>
        ///  Method For Gallon
        /// </summary>
        /// <param name="fahrenhit"> input fahrenhit</param>
        /// <returns> Convert Degree farenhit to celcius </returns>
        public double FarenhitToCelcius(double fahrenhit)
        {
            double Celsius = (fahrenhit - 32) * 5 / 9;
            return Celsius;
        }
    }
}