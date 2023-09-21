using AnimalFarm.Utils.Enums;

namespace AnimalFarm.Model
{
    public interface IAnimal
    {
        #region Properties

        /// <summary>
        /// The animals Type
        /// </summary>
        EAnimal AnimalType { get; }
        
        /// <summary>
        /// The animals sex
        /// </summary>
        Sex Sex { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Get the animals reproduction method.
        /// </summary>
        /// <returns>Enum Reproduction</returns>
        Reproduction GetReproduction();

        /// <summary> 
        /// Get the animals number of legs.
        /// </summary>
        /// <returns>int Number of legs</returns>
        int GetLegs();

        /// <summary>
        /// Get the animals skin type.
        /// </summary>
        /// <returns>Enum SkinType</returns>
        SkinType GetSkinType();

        /// <summary>
        /// Get the age by which the animal leave the farm.
        /// </summary>
        /// <returns>int age</returns>
        int GetForwardAge();
        
        #endregion
    }
}
