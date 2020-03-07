using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCat = new cat();
            //myCat.name = "Jojo";
            //myCat.age = 12;
            //myCat.price = 100;
            //myCat.date = DateTime.Now;
            //myCat.catRace = race.Asian_cat;
            //myCat.catHome = new home {
            //    postcode = "00-002",
            //    town = "Warsaw"
            //};       

            var newCat = new cat();
            myCat.GetCopyByReflection(newCat);

            Console.WriteLine(newCat.age);
            Console.WriteLine(newCat.catRace);
            Console.WriteLine(newCat.catHome.town);
            Console.ReadLine();
        }

        public class cat {

            public cat()
            {
                name = "Jojo";
                age = 15;
                price = 100;
                date = DateTime.Now;
                catRace = race.Asian_cat;
                catHome = new home
                {
                    postcode = "00-002",
                    town = "Warsaw"
                };
            }
            public string name { get; set; }
            public int age { get; set; }
            public decimal price { get; set; }
            public DateTime date { get; set; }
            public race catRace {get; set;}
            public home catHome { get; set; }
        }

        public class home { 
            public string town { get; set; }
            public string postcode { get; set; }
        }

        public enum race
        {
            Abyssinian,
            Aegean,
            Asian_cat
        }
    }
}
