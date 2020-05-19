///-----------------------------------------------------------------
///   Class:       UnitLength
///   Description: method for consertion of unit Length feet,cm,yard and inch
///   Author:      Ruchika                   Date: 5/5/2020
///-----------------------------------------------------------------

using System;

namespace QualityMeasurment
{
    public class Conversionlength
    {
        /// <summary>
        /// Variable Declaration
        /// </summary>
        private double value;

        /// <summary>
        /// enum variable for length
        /// </summary>
        public enum Unit 
        {
            FEET_TO_INCH,
            INCH_TO_FEET,
            FEET_TO_YARD,
            YARD_TO_FEET,
            INCH_TO_YARD,
            YARD_TO_INCH,
            INCH_TO_CENTIMETER,
            CENTIMETER_TO_INCH
        }
        /// <summary>
        /// Main Method
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quality Measurment problem");
        }

        /// <summary>
        /// Method for Length measurement
        /// </summary>
        /// <param name="input"> input </param>
        /// <param name="option"> input </param>
        /// <returns> Calculate Measurement </returns>
        public double Measure(Unit option, string input)
        {
            try
            {
                //if input type is not equal to null
                if (input != null)
                {
                    // Calculate feet value
                    if (double.TryParse(input, out value))
                    {
                        // Switch case for Feet ,Inches,yard,Centimeter
                        switch (option)
                        {
                            case Unit.FEET_TO_INCH:
                                //conversion of feet to inch
                                double feetToInch = value * 12.0;
                                return feetToInch;
                            case Unit.INCH_TO_FEET:
                                //conversion of inch to feet
                                double inchToFeet = value / 12.0;
                                return inchToFeet;
                            case Unit.FEET_TO_YARD:
                                //conversion of feet to yard
                                double feetToyard = value / 3.0;
                                return feetToyard;
                            case Unit.YARD_TO_FEET:
                                //conversion of yard to feet
                                double yardToFeet = value * 3.0;
                                return yardToFeet;
                            case Unit.INCH_TO_YARD:
                                //conversion of inch to yard
                                double inchToYard = value / 36.0;
                                return inchToYard;
                            case Unit.YARD_TO_INCH:
                                //conversion of yard to inch
                                double yardToInch = value * 36.0;
                                return yardToInch;
                            case Unit.INCH_TO_CENTIMETER:
                                //conversion of inch to centimeter 
                                double inchToCentimeter = value * 2.5;
                                return inchToCentimeter;
                            case Unit.CENTIMETER_TO_INCH:
                                //conversion of centimetere to inch
                                double centimeterToInch = value / 2.5;
                                return centimeterToInch;
                            default:
                                //For wrong oprtion
                                Console.WriteLine("Invalid Option");
                                return 0;
                        };
                    }
                    else
                    {
                        // throw Type Not Match exception
                        throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Type Not Match");
                    }
                }
                else
                {
                    // throw Null exception when value is null
                    throw new CustomException(CustomException.ExceptionType.INPUT_NULL, "Null");
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_CHOICE, "Invalid Choice");
            }
        }
    }
}