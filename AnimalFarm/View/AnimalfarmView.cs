using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.View
{
    /// <summary>
    /// Contains generic view methods.
    /// </summary>
    internal static class AnimalfarmView
    {
        /// <summary>
        /// Prompt user to to press any key to continue.
        /// </summary>
        internal static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to conintue");
            Console.ReadKey();
        }

        /// <summary>
        /// Clear the console.
        /// </summary>
        public static void Clear()
        {
            Console.Clear();
        }
    }
}
