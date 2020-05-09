///-----------------------------------------------------------------
///   Class:       UnitTemprature
///   Description:Method for calculate temperature
///   Author:      Ruchika                   Date: 5/5/2020
///-----------------------------------------------------------------

namespace QuantityMeasurment
{
    public class Conversiontemprature
    {
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
