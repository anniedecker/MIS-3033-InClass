using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionExample
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
          var icecreams = new List<IceCream>
            {
                new IceCream() { Size="Small", Scoops = 1},
                new IceCream() { Size="Medium", Scoops =2},
                new IceCream() { Size="Large", Scoops =3},
                new IceCream() { Size="Double Decker", Scoops = 4}
            };

            foreach (IceCream iceCream in icecreams)
            {
                Console.WriteLine("A " + iceCream.Size + " has " + iceCream.Scoops + " scoops");
            }
        }
    }
}      
