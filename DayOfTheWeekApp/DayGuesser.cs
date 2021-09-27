using DayOfTheWeekApp.core;
using System;

namespace DayOfTheWeekApp
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset dateOfBirth { get; set; }
        public DayOfTheWeek UserDayOfTheWeek { get; set; }
        public void Welcome() 
        {
            System.Console.WriteLine("Witaj w aplikacji! Potrafię podać, w którym dniu tygodnia się urodziłeś.");
            Calculator = new DayCalculator();
        }


        public void AskUserForDateOfBirth()
        {
          
            System.Console.WriteLine("Podaj swoją datę urodzenia: (DD.MM.RRRR)");
            
            var userDate = Console.ReadLine();
          
            var succeded = DateTimeOffset.TryParse(userDate, out var date);
            if (succeded)
            {
                dateOfBirth = date;
                return;
            }
            Console.WriteLine("Wpisano zły format daty. Proszę podać odpowiedni format daty!");
            
            
            AskUserForDateOfBirth();
        }

        public void CalculateTheDateOfTheWeek()
        {
            if (dateOfBirth == null)
            {
                Console.WriteLine("Próbowano podać dzień tygodnia bez podania daty urodzenia!");
                return;
            }
            UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(dateOfBirth);
             

        }

        public void PrintDayOfTheWeek()
        {
            System.Console.WriteLine("twój dzień urodzin to: " + UserDayOfTheWeek.ToPolishString());
        }
    }

}
