using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23
{
    public class Plant
    {
        protected string _name;
        protected int _power;
        public bool isPlant { get; set; } = false;

        public  virtual string name
        {
            get { return _name; }

        }
        internal Plant(string name)
        {
            _name = name;
        }
        internal Plant()
        {

        }
        virtual public int power
        {
            get
            {
                if (_power < 0)
                {
                    return 0;
                }
                else
                {
                    return _power;
                }
            }
        }

        public virtual void Grow()
        {
            _power = 10;
        }

         


    }

    public class Turnip : Plant
    {
        internal Turnip()
        {
            _name = "Ріпка";
        }
        
        public override void Grow()
        {

            _power= GeneratePower();
        }
        public override int power
            {
                get
                {
                   if(_power < 0)
                   {
                      return 0;
                   }
                   else 
                   {
                      return _power;
                   }
                }
            }
        
        private int GeneratePower()
        {
           Random random = new Random();
           return random.Next(1, 20);
        }
    }
}
