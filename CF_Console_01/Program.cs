using CF_Console_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF_Console_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ToDoContext();
            Console.WriteLine(db.ToDoItems.Count());

            Console.ReadLine();
        }
    }
}
