using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BrownBear :IBear
    {
        public bool Hibernating { get; set; }

        public void Roar()
        {
            if(!Hibernating)
            {
                Console.WriteLine("Rooooooar");
            }

        }
        public void LookAt(object objectToLookAt)
        {
            if (!Hibernating)
            {
                Console.writeLine("Brown Bear looks at" + objectToLookAt.ToString());
                
            }
        }
        public void GoTowards(object objectToWalkTowards)
        {
            if (!Hibernating)
            {
                Console.WriteLine("Brown Bear walks towards" + objectToWalkTowards.ToString());
            }
        }
        public bool TryEat(object objectToEat)
        {
            if (!Hibernating)
            {
                Console.WriteLine("Bear eats" + objectToEat.ToString());
                return true;
            }

            return false;

        }
    }
}