using DayOfTheWeekApp.core;
using System;

namespace DayOfTheWeekApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Title = "Day Of The Week App";
            var guesser = new DayGuesser();
            guesser.Welcome();
            guesser.AskUserForDateOfBirth();
            guesser.CalculateTheDateOfTheWeek();
            guesser.PrintDayOfTheWeek();
            System.Threading.Thread.Sleep(5000);
        }
    }
}
