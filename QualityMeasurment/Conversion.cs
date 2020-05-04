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

        /// <summary>
        /// Main Method
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quality Measurment problem");
        }
        public enum Unit { feet, inch, yard }
        /// <summary>
        /// Method to Feet
        /// </summary>
        /// <param name="input"> input </param>
        /// <returns> Calculate Feet </returns>
        public double Measure(Unit option,string input)
        {
            //if input type is not equal to null
            if (input != null)
            {
                // Calculate feet value
                if (double.TryParse(input, out inch))
                {
                    // Switch case
                    switch (option)
                    {
                        case Unit.feet:
                            return GetFeet(feet);
                        case Unit.inch:
                            return GetInch(inch);
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

        public double GetFeet(double inch)
        {
            return feet = inch * 12;
        }
        public double GetInch(double feet)
        {
            return inch = feet / 12;
        }
       
    }
}