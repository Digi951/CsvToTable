using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.View
{
    public static class PrintTable
    {
        public static void Print(IEnumerable<PersonModel> persons)
        {
            var maxNameLength = persons.Max(p => p.Name.Length);
            var maxStreetLength = persons.Max(p => p.Street.Length);
            var maxCityLength = persons.Max(p => p.City.Length);
            var maxAgeLength = persons.Max(p => p.Age.ToString().Length);

            var headerAndFooterLine = new string('-',maxNameLength + maxStreetLength + maxCityLength + maxAgeLength + 5); 
            var divider = new StringBuilder();
            divider.Append('+');
            divider.Append(new string('-', maxNameLength));
            divider.Append('+');
            divider.Append(new string('-', maxStreetLength));
            divider.Append('+');
            divider.Append(new string('-', maxCityLength));
            divider.Append('+');
            divider.Append(new string('-', maxAgeLength));
            divider.Append('+');
            
            Console.WriteLine(headerAndFooterLine);

            var index = 0;
            foreach (var person in persons)
            {
                Console.WriteLine(string.Format($"|{person.Name.PadRight(maxNameLength)}|{person.Street.PadRight(maxStreetLength)}|{person.City.PadRight(maxCityLength)}|{person.Age.PadRight(maxAgeLength)}|"));
                if(index == 0)
                {
                    Console.WriteLine(divider);
                }
                index++;
            }
            Console.WriteLine(headerAndFooterLine);
        }
    }
}