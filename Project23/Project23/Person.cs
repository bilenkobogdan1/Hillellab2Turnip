using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23
{
    public class Person
    {
        public Person next;
        protected string _name;
        public int power { get; } = 0;
        public string name
        {
            get { return _name; }

        }
        public Person(string name)
        {
            _name = name;
            power = GeneratePower();
        }
        private int GeneratePower()
        {
            Random random = new Random();
            return random.Next(1, 5);
        }
        public Person()
        {
            power = GeneratePower();
        }

    }

     public class GrendFather : Person
     {
       public GrendFather()
        {
            _name = "Дід";
        }
         

        internal void ToPlant(Plant plants)
        {
            plants.isPlant = true;
            Console.WriteLine($"Дід посадив: '{plants.name}'");
        }

        public bool Pull(Plant plants)
        {
            Person curent = this;
            int curentPower = power;
            while (curent.next != null)
            {
                curentPower += curent.power;
                curent = curent.next;
            }
            if (curentPower < plants.power)
            {
                Console.WriteLine($"Дід не зміг витягнути '{plants.name}'");
                return false;
            }
            else
            {
                Console.WriteLine($"Дід витягнув '{plants.name}'");
                return true;
            }
        }

        public void Help(Person person)
        {
            Person curent = this;
            while(curent.next != null)
            {
                curent = curent.next;
            }
            curent.next = person;
            Console.WriteLine($"кличимо на допомогу {person.name}");
        }
    }
}
