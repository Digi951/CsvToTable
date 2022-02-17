using System;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = Controller.TableHelper.GetTable();
            View.PrintTable.Print(table);
        }
    }
}
