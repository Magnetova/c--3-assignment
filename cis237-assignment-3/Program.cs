// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

using System;

namespace cis237_assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Allow Jawa to add a new droid of either(Protocol, Utility, Janitor, or Astromech) to the list
            //Allow Jawa to print the list of droids out.
            //Do NOT make any changes to the IDroid interface.
            //Create abstract class Droid that implements IDroid
            //Derive two classes(Protocol and Utility) from the class Droid
            //Derive two classes(Janitor and Astromech) from the class Utility
            //Each derived class (Protocol, Utility, Janitor, and Astromnech) must either implement or override the ToString and CalculateTotalCost methods
            //Create a UI class
            //Create a DroidCollection class
            //Use private, public and protected appropriately.
            //Use abstract, virtual, and override appropriately.
            //Have sufficient comments about what you are doing in the code.



            UserInterface ui = new UserInterface();
            DroidCollection droidCollection = new DroidCollection();
            string choice = "";
            choice = ui.PrintMenu();
            Console.WriteLine("\n\n");


            while (choice != "3")
            {
                if (choice == "1")
                {
                    //Add droid
                    ui.AddNewDroid(droidCollection);
                }
                if (choice == "2")
                {
                    //Print List
                    ui.PrintList(droidCollection);
                }
                else if (choice != "1" && choice != "2" && choice != "3")
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
                choice = ui.PrintMenu();
                Console.WriteLine("\n\n");
            }

        }
    }
}
