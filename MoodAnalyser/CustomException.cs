using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{ 
        public class CustomException : Exception
        {
            public enum ExceptionType
            {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_CLASS, NO_SUCH_METHOD, NO_SUCH_FIELD, OBJECT_CREATION_ISSUE
            }
            public readonly ExceptionType type;
            public CustomException(ExceptionType Type, String message) : base(message)
            {
                this.type = Type;
            }
        }
    
}
