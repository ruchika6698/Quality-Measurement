﻿using System;

namespace QualityMeasurment
{
    public class CustomException : Exception
    {
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