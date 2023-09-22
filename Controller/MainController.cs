using Bo_Godt.Model.Apartment_Builder;
using Bo_Godt.View.Welcome_Screen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_Godt.Controller
{
    internal class MainController
    {

        /// <summary>
        /// This method runs the entirety of the program.
        /// </summary>
        internal void Start()
        {
            WelcomeScreen screen = new WelcomeScreen();
            // Printing the start screen
            List<short> apartmentsAvailable = screen.amountOfApartments();
            // Printing available apartmnets to renovate
            screen.StartScreen();
            screen.PrintHowManyApartmentsToRenovate(apartmentsAvailable);
            Console.ReadLine();
        }
    }
}
