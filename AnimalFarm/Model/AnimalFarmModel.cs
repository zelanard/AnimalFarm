using AnimalFarm.Model.Animals;
using AnimalFarm.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalFarm.Model
{
    /// <summary>
    /// <c>AnimalFarm</c> models an animal farm.
    /// </summary>
    public class AnimalFarmModel
    {
        private List<IAnimal> _animals;

        //Constructors
        public AnimalFarmModel()
        {
            Animals = new List<IAnimal>();
        }

        //Properties
        /// <summary>
        /// Get/Set Animals
        /// </summary>
        public List<IAnimal> Animals
        {
            get
            {
                return _animals;
            }

            private set
            {
                _animals = value;
            }
        }

        //Methods
        /// <summary>
        /// Extract a list containing all animals of a certain type.
        /// </summary>
        /// <param name="animalType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public List<IAnimal> ExtractAnimals(EAnimal animalType) 
        {
            return Animals.Where(a => a.AnimalType == animalType).ToList();
        }

        /// <summary>
        /// Add a newly generatd animal to Animals
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="sex"></param>
        internal void AddAnimal(EAnimal animal, Sex sex)
        {
            Animals.Add(NewAnimal(animal, sex));
        }

        /// <summary>
        /// Generate new animal.
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="sex"></param>
        /// <returns>Any Animal</returns>
        /// <exception cref="ArgumentException"></exception>
        private IAnimal NewAnimal(EAnimal animal, Sex sex)
        {
            switch (animal)
            {
                case EAnimal.Chicken:
                    {
                        return new Chicken(sex);
                    }
                case EAnimal.Dog:
                    {
                        return new Dog(sex);
                    }
                case EAnimal.Rabbit:
                    {
                        return new Rabbit(sex);
                    }
                default:
                    {
                        throw new ArgumentException();
                    }
            }
        }
    }
}