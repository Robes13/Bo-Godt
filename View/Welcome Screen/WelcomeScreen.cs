using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.View.Welcome_Screen
{
    /// <summary>
    /// This class handles the start of the program so to speak. The user adds how many apartments they currently need to renovate.
    /// </summary>
    internal class WelcomeScreen
    {
        /// <summary>
        ///  Here we can see the available apartments.
        /// </summary>
        #region Fields 
        List<string> youHaveApartments = new List<string>()
            {
                "One room apartments","Two room apartments", "Three room apartments", "Four room apartments", "Five room apartments"
            };
        #endregion Fields
        /// <summary>
        /// This method prints the start
        /// </summary>
        internal void StartScreen()
        {
            Console.WriteLine("Please enter the amount of money you have: ");
            int money;
            int.TryParse(Console.ReadLine(), out money);
            Console.Clear();
            Console.WriteLine("Welcome to the Apartment Builder!");
            Console.WriteLine($"You have {money}$ to start renovating apartments for.");
            Console.WriteLine("I-----------------------------------------------------------I");
        }
        internal void PrintHowManyApartmentsToRenovate(List<short> amountOfApartments)
        {
            byte count = 0;
            foreach (short amount in amountOfApartments)
            {
                Console.WriteLine($"{youHaveApartments[count]}: {amount}");
                count++;
            }
        }
        internal List<short> amountOfApartments()
        {
            byte count = 0;
            List<short> list = new List<short>();
            while(count < youHaveApartments.Count)
            {
                Console.Clear();
                Console.WriteLine($"Please enter the amount of {youHaveApartments[count]} there is available: ");
                string? apartment = Console.ReadLine();
                // Making sure that the correct format was inputted
                try
                {
                    short number;
                    bool succes = short.TryParse(apartment, out number);
                    if (succes) 
                    {
                        list.Add(number);
                        Console.Write($"\n{number} added. ");
                        Thread.Sleep(700);
                        Console.Write(". ");
                        Thread.Sleep(700);
                        Console.Write(". ");
                        Thread.Sleep(700);
                        Console.Write(".");
                        count++;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Problem when adding amount of {youHaveApartments[count]} in the program. Are you sure you entered the correct value?");
                    Console.WriteLine($"This error occured: \n\n{ex.Message}");
                    throw new ArgumentException($"Problem when adding amount of {youHaveApartments[count]} in the program. Are you sure you entered the correct value?");
                }
            }
            Console.Clear();
            return list;
        }

    }
}
