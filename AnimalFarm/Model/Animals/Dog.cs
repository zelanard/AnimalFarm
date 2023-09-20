using AnimalFarm.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Model.Animals
{
    /// <summary>
    /// <c>Dog</c> models a dog.
    /// </summary>
    internal class Dog : Animal
    {
        public Dog(Sex sex) : base(EAnimal.Dog)
        {
            Sex = sex;
        }
    }
}
