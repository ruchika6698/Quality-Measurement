using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurment
{
    public class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quality Measurment problem");
            Conversion feet = new Conversion();
            double feett = feet.length(Conversion.Unit.feet, "1");
            Console.WriteLine(feett);
            double inch = feet.length(Conversion.Unit.inch, "12");
            Console.WriteLine(inch);
            double yard = feet.length(Conversion.Unit.yard, "1");
            Console.WriteLine(yard);
        }
    }
}
