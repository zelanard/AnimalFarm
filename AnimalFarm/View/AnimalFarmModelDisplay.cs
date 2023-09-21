using AnimalFarm.Model;
using AnimalFarm.Model.Animals;
using System;
using System.Collections.Generic;

namespace AnimalFarm.View
{
    /// <summary>
    /// <c>AnimalFarmModelDisplay</c> contains methods to display the AnimalFarmModel.
    /// </summary>
    public static class AnimalFarmModelDisplay
    {
        /// <summary>
        /// Print [Type of animals]: [animals.Count], to the console.
        /// </summary>
        /// <param name="animals"></param>
        public static void PrintAnimals(List<IAnimal> animals)
        {
            try
            {
                if (animals[0] is Chicken)
                {
                    Console.WriteLine($"{(Chicken)animals[0]}: {animals.Count}");
                }
                else if (animals[0] is Dog)
                {
                    Console.WriteLine($"{(Dog)animals[0]}: {animals.Count}");
                }
                else if (animals[0] is Rabbit)
                {
                    Console.WriteLine($"{(Rabbit)animals[0]}: {animals.Count}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Your list of animals was empty!");
            }
        }
    }
}
