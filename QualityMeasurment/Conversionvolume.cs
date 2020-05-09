///-----------------------------------------------------------------
///   Class:       UnitVolume
///   Description: Method for consertion of Volume Gallon,litre and mililitre
///   Author:      Ruchika                   Date: 5/5/2020
///-----------------------------------------------------------------

using System;

namespace QuantityMeasurment
{
    public class Conversionvolume
    {
        /// <summary>
        /// enum variable for volume
        /// </summary>
        public enum Volume
        {
            GALLON_TO_LITRE,
            LITRE_TO_MILLILITER,
            MILILITRE_TO_LITER,
        };

        /// <summary>
        /// Method for compare Volume
        /// </summary>
        /// <param name="option"></param>
        /// <param name="value"></param>
        /// <returns>Compare Volume</returns>
        public double Comparevolume(Volume option, double value)
        {
     
            switch (option)
            {
                case Volume.GALLON_TO_LITRE:
                    //conversion of Gallon to Litre
                    double gallonToLitre = value * 3.78;
                    return gallonToLitre;
                case Volume.LITRE_TO_MILLILITER:
                    //conversion of Litre to Mililitre
                    double litreToMililitre = value * 1000;
                    return litreToMililitre;
                case Volume.MILILITRE_TO_LITER:
                    //converioon of mililtre to litre
                    double mililitreToLitre = value / 1000;
                    return mililitreToLitre;
                default:
                    //For wrong oprtion
                    Console.WriteLine("Invalid Option");
                    return 0;
            }
        }
    }
}
