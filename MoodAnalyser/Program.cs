using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyaser analyse = new MoodAnalyaser("I am in Sad mood");
            Console.WriteLine(analyse.AnalyseMood());
        }
    }
}
