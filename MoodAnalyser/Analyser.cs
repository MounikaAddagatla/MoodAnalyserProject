using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
   public class Analyser
    {
        public string message;

        public Analyser(string message)
        {
            this.message = message;
        }
        public string Analyzer()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                   
                }
                
                if (this.message.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}
