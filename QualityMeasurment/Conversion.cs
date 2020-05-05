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

        public enum Unit { feet, inch, yard }
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
                    // Switch case for Feet ,Inches
                    switch (option)
                    {
                        case Unit.feet:
                            return GetFeet(feet);
                        case Unit.inch:
                            return GetInch(inch);
                        case Unit.yard:
                            return GetYard(yard);
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
            return feet = inch * 12;
        }

        /// <summary>
        /// Method for inch
        /// </summary>
        /// <param name="feet"> input feet </param>
        /// <returns> Calculate Inch </returns>
        public double GetInch(double feet)
        {
            return inch = feet / 12;
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
        internal double length(Unit feet, string v)
        {
            throw new NotImplementedException();
        }
    }
}