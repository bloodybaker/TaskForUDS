using System;
using CSharpTest;

namespace TestTaksProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkDayCalculator workDayCalculator = new WorkDayCalculator();
            DateTime dateTime = new DateTime(2017,4,18);
            WeekEnd weekEndFirst = new WeekEnd(new DateTime(2017,4,20), new DateTime(2017,4,23));
            WeekEnd weekEndSecond = new WeekEnd(new DateTime(2017,4,27),new DateTime(2017,4,29));
            WeekEnd[] weeks = {weekEndFirst,weekEndSecond};
            workDayCalculator.Calculate(dateTime,12,weeks);
        }
    }
}