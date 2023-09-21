using AnimalFarm.Utils.Enums;

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
