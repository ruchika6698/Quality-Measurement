///-----------------------------------------------------------------
///   Class:       UnitWeight
///   Description: Method for consertion of weight in KG,Gram,Tone
///   Author:      Ruchika                   Date: 5/5/2020
///-----------------------------------------------------------------

using QualityMeasurment;
using System;

namespace QuantityMeasurment
{
    public class Coversionweight
    {
        /// <summary>
        /// enum variable for Weight
        /// </summary>
        public enum Weight
        {
            KILOGRAM_TO_GRAM,
            TONNE_TO_KILOGRAM,
            GRAM_TO_KILOGRAM
        };

        /// <summary>
        /// Method for compare Weight
        /// </summary>
        /// <param name="option"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public double CompareWeight(Weight option, double weight)
        {
            try
            {
                switch (option)
                {
                    case Weight.KILOGRAM_TO_GRAM:
                        //conversion of kg to gram
                        double kilogramToGram = weight * 1000;
                        return kilogramToGram;
                    case Weight.TONNE_TO_KILOGRAM:
                        //conversion fo tone to kg
                        double tonneToKilogram = weight * 1000;
                        return tonneToKilogram;
                    case Weight.GRAM_TO_KILOGRAM:
                        //conversion of gram to kg
                        double gramToKilogram = weight / 1000;
                        return gramToKilogram;
                    default:
                        //For wrong oprtion
                        Console.WriteLine("Invalid Option");
                        return 0;
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_CHOICE, "Invalid Choice");
            }
        }
    }
}
