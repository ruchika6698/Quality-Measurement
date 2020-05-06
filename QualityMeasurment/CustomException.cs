///-----------------------------------------------------------------
///   Class:       CustomException
///   Description: CustomException for null ans type not match
///   Author:      Ruchika                   Date: 5/5/2020
///-----------------------------------------------------------------

using System;

namespace QualityMeasurment
{
    /// <summary>
    ///Class for Exception
    /// </summary>
    public class CustomException : Exception
    {
        /// <summary>
        /// enum Exception typw
        /// </summary>
        public enum ExceptionType
        {
            INPUT_NULL, 
            TYPE_NOT_MATCH
        }

        public CustomException(string message, ExceptionType TYPE_NOT_MATCH) : base(message)
        {
        }
    }
}