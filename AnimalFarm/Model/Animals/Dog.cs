using AnimalFarm.Utils.Enums;

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
