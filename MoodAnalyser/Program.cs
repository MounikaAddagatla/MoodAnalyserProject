using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Mood Analyser Project");
            Analyser mood = new Analyser();
            Console.WriteLine(mood.Analyzer(" I am sad mood "));
            Console.ReadLine();
        }
    }
}
