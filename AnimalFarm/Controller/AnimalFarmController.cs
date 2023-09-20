using AnimalFarm.View;
using AnimalFarm.Model;
using AnimalFarm.Utils.Enums;
using System.Threading;

namespace AnimalFarm.Controller
{
    /// <summary>
    /// <c>AnimalFarmController</c> controls the animal farm.
    /// </summary>
    public class AnimalFarmController
    {
        /// <summary>
        /// Run the animal farm
        /// </summary>
        public static void RunAnimalFarm()
        {
            AnimalFarmModel farm;

            while(true)
            {
                AnimalfarmView.Clear();
                AnimalfarmView.Welcome();

                farm = Generator.AnimalFarm();
                AnimalFarmModelDisplay.PrintAnimals(farm.ExtractAnimals(EAnimal.Chicken));
                AnimalFarmModelDisplay.PrintAnimals(farm.ExtractAnimals(EAnimal.Dog));
                AnimalFarmModelDisplay.PrintAnimals(farm.ExtractAnimals(EAnimal.Rabbit));
                AnimalfarmView.Play(AnimalfarmView.Welcome);
                AnimalfarmView.WaitForAnyKey();
            }
        }
    }
}
