using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsProject
{
    public class Duck:IAnimal
    {
        public string makeSound()
        {
            return ("Quack-Quack");
        }
    }
}
