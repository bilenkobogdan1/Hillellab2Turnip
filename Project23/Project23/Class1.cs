using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23
{
    internal class Class1
    {
        internal static void Main()
        {
            Console.WriteLine("Hello world");
            Plant turnip = new Turnip();
            GrendFather grendFather = new GrendFather();
            List<Person> people = new List<Person>()
            {
                new Person("Бабця"),
                new Person("Онучка"),
                new Person("Жучка"),
                new Person("Жучка2"),
            };
            FairytaleScenario.Create(grendFather, turnip, people);
            Console.ReadLine();
        }
    }
}
