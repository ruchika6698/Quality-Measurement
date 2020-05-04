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
            double inch = 12;

            if (input != null)
            {
                if (double.TryParse(input, out feet))
                {
                    feet = feet * inch;
                }
                else
                {
                    throw new CustomException("Type Not Match",CustomException.ExceptionType.TYPE_NOT_MATCH);
                }
            }
            else
            {
                throw new CustomException("Null",CustomException.ExceptionType.INPUT_NULL);
            }
            return feet;
        }
    }
}
