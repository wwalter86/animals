using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal>AnimalsList=new List<LAnimal>();
            AnimalsList.Add(new Pig());
            AnimalsList.Add(new Cow());
            AnimalsList.Add(new Duck());
            AnimalsList.Add(new Frog());
            
            foreach (LAnimal animal in AnimalsList)
            {
                Console.WriteLine("{0} makes {1}.", animal.GetType().Name, animal.makeSound());
            }
            Console.ReadKey();
        }
    }
}
