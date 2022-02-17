using System.Collections.Generic;
using System.IO;

namespace Logic.Controller
{
    public static class TableHelper
    {
        public static IEnumerable<PersonModel> GetTable()
        {
            var path = @"/Users/digi/Programmierung/CsvToTable/Logic/Table.csv";
            var reader = new StreamReader(path);
            var persons = new List<PersonModel>();

            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                persons.Add(new PersonModel
                {
                    Name = values[0],
                    Street = values[1],
                    City = values[2],
                    Age = values[3]
                });
            }

            return (IEnumerable<PersonModel>)persons;
        }
    }
}