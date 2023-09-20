using AnimalFarm.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Model.Animals
{
    /// <summary>
    /// <c>Rabbit</c> models a rabbit.
    /// </summary>
    internal class Rabbit : Animal
    {
        public Rabbit(Sex sex) : base(EAnimal.Rabbit)
        {
            Sex = sex;
        }
    }
}
