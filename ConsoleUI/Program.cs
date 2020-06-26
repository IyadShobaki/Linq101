using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Person> People = ListManager.LoadSampleData();

            //People = People.OrderBy(x => x.LastName).ToList();
            //People = People.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearExperience).ToList();
            //People = People.Where(x => x.YearExperience > 9 && x.Birthday.Month == 3).ToList();


            //foreach (var person in People)
            //{
            //    Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString() }): Experience { person.YearExperience }");
            //}

            int yearsTotal = 0;
            //int yearsTotal = People.Sum(x => x.YearExperience);
            yearsTotal = People.Where(x => x.Birthday.Month == 3).Sum(x => x.YearExperience);

            Console.WriteLine($"The total years experience is { yearsTotal }");

            Console.ReadLine();
        }
    }
}
