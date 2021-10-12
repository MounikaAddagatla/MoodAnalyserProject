using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
   public class Analyser
    {
        public string Analyzer(string mood)
        {
            if (mood.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
