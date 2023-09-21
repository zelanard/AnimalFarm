using AnimalFarm.Utils;
using AnimalFarm.Utils.Enums;

namespace AnimalFarm.Model
{
    /// <summary>
    /// <c>Animal</c> models an aimal
    /// </summary>
    public abstract class Animal : IAnimal
    {
        //Summary in IAnimal
        protected EAnimal _animalType;

        //Summary in IAnimal
        protected Sex _sex;

        #region Constructors

        /// <summary>
        /// Construct an Animal
        /// </summary>
        /// <param name="animalType"></param>
        protected Animal(EAnimal animalType)
        {
            AnimalType = animalType;
        }

        #endregion

        #region Properties

        //Summary in IAnimal
        public EAnimal AnimalType
        {
            protected set
            {
                _animalType = value;
            }

            get
            {
                return _animalType;
            }
        }

        //Summary in IAnimal
        public Sex Sex
        {
            protected set
            {
                _sex = value;
            }
            get
            {
                return _sex;
            }
        }

        #endregion

        #region Methods

        //Summary in IAnimal
        public int GetForwardAge()
        {
            return AnimalWiki.AnimalAge[_animalType];
        }

        //Summary in IAnimal
        public int GetLegs()
        {
            return AnimalWiki.Legs[_animalType];
        }

        //Summary in IAnimal
        public Reproduction GetReproduction()
        {
            return AnimalWiki.AnimalReproduction[_animalType];
        }

        //Summary in IAnimal
        public SkinType GetSkinType()
        {
            return AnimalWiki.AnimalSkinType[_animalType];
        }

        //Summary in IAnimal
        public override string ToString()
        {
            return $"" +
                $"Animal: {AnimalType}, " +
                //$"Sex: {Sex}, " +
                //$"Forward Age: {GetForwardAge()}, " +
                //$"Legs: {GetLegs()}" +
                //$"Reproduction: {GetReproduction()}, " +
                //$"Skin Type: {GetSkinType()}" +
                $"";
        }

        #endregion
    }
}
