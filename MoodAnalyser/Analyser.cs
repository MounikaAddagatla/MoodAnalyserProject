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
