using AnimalFarm.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimalFarm.Model
{
    /// <summary>
    /// <c>Generator</c> Generates data.
    /// </summary>
    public static class Generator
    {
        private static Random rnd = new Random();

        /// <summary>
        /// Generate a farm with random numbers of animals.
        /// </summary>
        /// <returns></returns>
        public static AnimalFarmModel AnimalFarm()
        {
            AnimalFarmModel farm = new AnimalFarmModel();
            while (Generator.rnd.Next(0, 500) != 1)
            {
                farm.AddAnimal(EAnimal.Chicken, Sex.Female);
            }
            while (Generator.rnd.Next(0, 50) != 1)
            {
                farm.AddAnimal(EAnimal.Chicken, Sex.Male);
            }
            while (Generator.rnd.Next(0, 50) != 1)
            {
                farm.AddAnimal(EAnimal.Dog, Sex.Female);
            }
            while (Generator.rnd.Next(0, 10) != 1)
            {
                farm.AddAnimal(EAnimal.Dog, Sex.Male);
            }
            while (Generator.rnd.Next(0, 300) != 1)
            {
                farm.AddAnimal(EAnimal.Rabbit, Sex.Female);
            }
            while (Generator.rnd.Next(0, 50) != 1)
            {
                farm.AddAnimal(EAnimal.Rabbit, Sex.Male);
            }
            return farm;
        }
    }
}
