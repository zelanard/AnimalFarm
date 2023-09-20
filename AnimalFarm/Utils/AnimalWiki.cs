using AnimalFarm.Utils.Enums;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Utils
{
    /// <summary>
    /// <c>AnimalWiki</c> suply information about animals
    /// </summary>
    public static class AnimalWiki
    {
        /// <summary>
        /// Age by which the animal may leave the farm.
        /// </summary>
        internal static readonly Dictionary<EAnimal, int> AnimalAge = new Dictionary<EAnimal, int>
        {
            { EAnimal.Chicken, 5 },
            { EAnimal.Rabbit, 5 },
            { EAnimal.Dog, 5 }
        };
        
        /// <summary>
        /// Number of legs by animal.
        /// </summary>
        internal static readonly Dictionary<EAnimal, int> Legs = new Dictionary<EAnimal, int>
        {
            { EAnimal.Chicken, 2 },
            { EAnimal.Rabbit, 4 },
            { EAnimal.Dog, 4 }
        };
        
        /// <summary>
        /// How the animal reproduce.
        /// </summary>
        internal static readonly Dictionary<EAnimal, Reproduction> AnimalReproduction = new Dictionary<EAnimal, Reproduction>
        {
            { EAnimal.Chicken, Reproduction.Oviparity },
            { EAnimal.Rabbit, Reproduction.Viviparity },
            { EAnimal.Dog, Reproduction.Viviparity }
        };
        
        /// <summary>
        /// The Animals Skin Type.
        /// </summary>
        internal static readonly Dictionary<EAnimal, SkinType> AnimalSkinType = new Dictionary<EAnimal, SkinType>
        {
            { EAnimal.Chicken, SkinType.Feathers },
            { EAnimal.Rabbit, SkinType.Wool },
            { EAnimal.Dog, SkinType.ShortFur }
        };
    }
}
