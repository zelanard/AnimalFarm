using AnimalFarm.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Model.Animals
{
    /// <summary>
    /// <c>Chicken</c> models a checken.
    /// </summary>
    internal class Chicken : Animal
    {
        public Chicken(Sex sex) : base(EAnimal.Chicken)
        {
            Sex = sex;
        }
    }
}
