using AnimalFarm.Utils.Enums;

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
