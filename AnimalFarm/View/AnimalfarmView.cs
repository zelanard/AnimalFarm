using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        #region Not in Diagram

        private static Random rnd = new Random();

        /// <summary>
        /// create a blinking effect for the stars in the welcome screen.
        /// </summary>
        /// <returns>" . ", "+" or "*"</returns>
        /// <include file='Documentation.xml' path='/documentation/remarks' />
        public static string Star()
        {
            int st = rnd.Next(0, 1000);
            if (st == 20)
            {
                return "*";
            }
            else if (st < 50)
            {
                return "+";
            }
            else
            {
                return ".";
            }
        }

        /// <summary>
        /// Create a welcome screen.
        /// </summary>
        /// <include file='Documentation.xml' path='/documentation/remarks' />
        public static void Welcome()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine();
            Console.WriteLine($"                            /|  {Star()}   __                       ");
            Console.WriteLine($"{Star()}       {Star()}             {Star()}    / |   ,-~ /             {Star()}         ");
            Console.WriteLine($"  {Star()}         {Star()}             Y :|  //  /                {Star()}       ");
            Console.WriteLine($"                {Star()}         | jj /( .^     {Star()}                   ");
            Console.WriteLine($"   {Star()}                {Star()}     >-\"~\"-v\"              {Star()}        {Star()}");
            Console.WriteLine($"        {Star()}                /       Y                           ");
            Console.WriteLine($"        {Star()}     {Star()}         jo  o    |     {Star()}            {Star()}        ");
            Console.WriteLine($"  {Star()}                    ( ~T~     j                     {Star()}     ");
            Console.WriteLine($"            {Star()}           >._-' _./         {Star()}                  ");
            Console.WriteLine($"                     /| ;-\"~ _  l                           ");
            Console.WriteLine($"        {Star()}           / l/ ,-\"~    \\     {Star()}        {Star()}          ");
            Console.WriteLine($"                    \\//\\/      .- \\                       ");
            Console.WriteLine($"            {Star()}        Y        /    Y            {Star()}             ");
            Console.WriteLine($"     {Star()}               l       I     !                         ");
            Console.WriteLine($"              {Star()}      ]\\      _\\    /\"\\   {Star()}            {Star()}  ");
            Console.WriteLine($"                    (\" ~----( ~   Y.  )     {Star()}               ");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~ The Animal Farm ~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
        }


        /// <summary>
        /// Play action until any key is pressed.
        /// </summary>
        /// <param name="action"></param>
        /// <include file='Documentation.xml' path='/documentation/remarks' />
        internal static void Play(Action action)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    action();
                }
                Thread.Sleep(1000);
            }
        }
        #endregion
    }
}
