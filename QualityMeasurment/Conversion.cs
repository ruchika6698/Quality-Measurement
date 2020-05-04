using System;

namespace QualityMeasurment
{
    public class Conversion
    {
        /// <summary>
        /// Variable Declaration
        /// </summary>
        public int feet;

        /// <summary>
        /// Main Method
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quality Measurment problem");
        }

        /// <summary>
        /// Method to Feet
        /// </summary>
        /// <param name="input"> input </param>
        /// <returns> Calculate Feet </returns>
        public double Feetmeasure(string input)
        {
            double feet;
            // given 1ft=12 inch
            double inch = 12;
            //if input type is not equal to null
            if (input != null)
            {
                // Calculate feet value
                if (double.TryParse(input, out feet))
                {
                    feet = feet * inch;
                }
                else
                {
                    //else throw Type Not Match exception
                    throw new CustomException("Type Not Match",CustomException.ExceptionType.TYPE_NOT_MATCH);
                }
            }
            else
            {
                //else throw Null exception
                throw new CustomException("Null",CustomException.ExceptionType.INPUT_NULL);
            }
            return feet;
        }
    }
}
