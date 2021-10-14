using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{ 
        public class CustomException : Exception
        {
            public enum ExceptionType
            {
                NULL_MESSAGE, EMPTY_MESSAGE
            }
            public readonly ExceptionType type;
            public CustomException(ExceptionType Type, String message) : base(message)
            {
                this.type = Type;
            }
        }
    
}
