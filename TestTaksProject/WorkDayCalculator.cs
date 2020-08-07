﻿using System;
using System.Collections.Generic;

 namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        private DateTime result;
        private List<DateTime> dateTimes = new List<DateTime>();
        private List<DateTime> exeptDates =  new List<DateTime>();

        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            if (weekEnds != null)
            {
                foreach (var date in weekEnds)
                {
                    for (int i = 0; i <= (date.EndDate - date.StartDate).TotalDays; i++)
                    {
                        exeptDates.Add(date.StartDate.AddDays(i));
                    }
                }

                foreach (var date in exeptDates)
                {
                    Console.WriteLine(date.ToShortDateString());
                }

                Console.WriteLine("==========================");
                for (int i = 0; i < dayCount; i++)
                {
                    dateTimes.Add(startDate.AddDays(i));
                }

                int countOfWeekends = exeptDates.Count;
                DateTime lastday = dateTimes[dateTimes.Count - 1];
                for (int i = 1; i < countOfWeekends; i++)
                {
                    dateTimes.Add(lastday.AddDays(i));
                }

                foreach (var exceptDate in exeptDates)
                {
                    Console.WriteLine("Выходной: = " + exceptDate.ToShortDateString());
                    dateTimes.Remove(exceptDate);
                }

                Console.WriteLine("Колво-выходных " + countOfWeekends);
                Console.WriteLine("==========================");

                foreach (var element in dateTimes)
                {
                    Console.WriteLine("Рабочий день: " + element.ToShortDateString());
                }

                return dateTimes[dateTimes.Count - 1];
            }
            else
            {
                for (int i = 0; i < dayCount; i++)
                {
                    dateTimes.Add(startDate.AddDays(i));
                }

                return dateTimes[dateTimes.Count - 1];
            }
        }
    }
}
