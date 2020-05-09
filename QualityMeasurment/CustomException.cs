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
        public ExceptionType type;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="type"></param>
        public CustomException(ExceptionType type)
        {
            this.type = type;
        }
        public CustomException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }

        public CustomException(string message, ExceptionType TYPE_NOT_MATCH) : base(message)
        {
        }
    }
}