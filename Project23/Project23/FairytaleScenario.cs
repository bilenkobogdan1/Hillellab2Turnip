using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23
{
    public static class FairytaleScenario
    {
        public static void Create(GrendFather grendFather, Plant plant, List<Person> persons )
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            bool IsCrete = grendFather is null || plant is null;
            if (IsCrete)
            {
                throw new Exception("Create fairytale characters");
            }
            grendFather.ToPlant(plant);
            plant.Grow();
          //  grendFather.Pull(plant);
            foreach (var person in persons)
            {
                grendFather.Help(person);
                if (grendFather.Pull(plant))
                {
                     break;
                }
            }
            
        }

    }
}
