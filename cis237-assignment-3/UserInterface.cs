// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

using System;

namespace cis237_assignment_3
{
    internal class UserInterface
    {

        public string PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add Droid");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Exit");
            Console.Write("Selection: ");



            return Console.ReadLine();

          
        }

        public void PrintList(DroidCollection droidCollection)
        {
            //Print the list from the concat string
            Console.WriteLine(droidCollection.CollectionToString());
        }

        public void AddNewDroid(DroidCollection droidCollection)
        {
            //Collect user input for droid and pass to droid collection class
            string droidType = "";
            bool exitchecker = false;
            Console.WriteLine("What type of droid would you like to add?");
            Console.WriteLine("1. Protocol");
            Console.WriteLine("2. Utility");
            Console.WriteLine("3. Janitor");
            Console.WriteLine("4. Astromech");
            Console.Write("Selection: ");


            droidType = Console.ReadLine();

            do
            {
                if (droidType != "1" && droidType != "2" && droidType != "3" && droidType != "4")
                {
                    Console.WriteLine("Invalid option.");
                }
                else
                {
                    if (droidType == "1")
                    {
                        droidCollection.AddProtocolDroid(DroidMaterial(), DroidColor(), DroidNumberOfLanguages());
                        exitchecker = true;
                        Console.WriteLine("Protocol Droid Added!\n\n");
                    }
                    if (droidType == "2")
                    {
                        droidCollection.AddUtilityDroid(DroidMaterial(), DroidColor(), DroidToolbox(), DroidComputerConnection(), DroidScanner());
                        exitchecker = true;
                        Console.WriteLine("Utility Droid Added!\n\n");
                    }
                    if (droidType == "3")
                    {
                        droidCollection.AddJanitorDroid(DroidMaterial(), DroidColor(), DroidToolbox(), DroidComputerConnection(), DroidScanner(), DroidBroom(), DroidVacuum());
                        exitchecker = true;
                        Console.WriteLine("Janitor Droid Added!\n\n");
                    }
                    if(droidType == "4")
                    {
                        droidCollection.AddAstromechDroid(DroidMaterial(), DroidColor(), DroidToolbox(), DroidComputerConnection(), DroidScanner(), DroidNavigation(), DroidNumberOfShips());
                        exitchecker = true;
                        Console.WriteLine("Astromech Droid Added!\n\n");
                    }
                }
            }
            while (exitchecker == false);

        }

        private string DroidMaterial()
        {
            string droidMaterial = "";
            Console.WriteLine("What type of material will the Droid be made out of?");
            Console.WriteLine("1. Aluminum");
            Console.WriteLine("2. Gold");
            Console.WriteLine("3. Platinum");
            Console.Write("Selection: ");
            droidMaterial = Console.ReadLine();

            if (droidMaterial == "1")
            {
                return "Aluminum";
            }
            if (droidMaterial == "2")
            {
                return "Gold";
            }
            if (droidMaterial == "3")
            {
                return "Platinum";
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
                return "";
            }

        }

        private string DroidColor()
        {
            string droidColor = "";
            bool exitchecker = false;
            Console.WriteLine("What color will the Droid be?");
            Console.WriteLine("1. Black");
            Console.WriteLine("2. White");
            Console.WriteLine("3. Yellow");
            Console.Write("Selection: ");

            string selection = Console.ReadLine();
            do
            {
                if (selection == "1")
                {
                    exitchecker = true;
                    droidColor = "Black";
                }
                if (selection == "2")
                {
                    exitchecker= true;
                    droidColor = "White";
                }
                if (selection == "3")
                {
                    exitchecker = true;
                    droidColor = "Yellow";
                }
                else if(selection != "1" && selection != "2" && selection != "3")
                { 
                    Console.WriteLine("Invalid option. Please try again."); 
                }
                
            }
            while(exitchecker == false);
            return droidColor;

        }

        private int DroidNumberOfLanguages()
        {
            bool exitchecker = false;
            int droidNumberOfLanguages = 0;
            do
            {
                Console.WriteLine("How many languages will the Droid know?");
                Console.Write("Selection: ");

                droidNumberOfLanguages = int.Parse(Console.ReadLine());
                if(droidNumberOfLanguages >= 0)
                {
                    exitchecker = true;
                }
                if(droidNumberOfLanguages < 0)
                {
                    Console.WriteLine("Value must be greater than or equal to zero. Please try again.");
                }
            }
            while (exitchecker == false);

            return droidNumberOfLanguages;

        }

        private bool DroidToolbox()
        {
            bool exitchecker = false;
            bool toolbox = false;
            Console.WriteLine("Will the Droid have a toolbox?");
            Console.WriteLine("1 = Yes");
            Console.WriteLine("2 = No");
            Console.Write("Selection: ");

            string selection = Console.ReadLine();
            do
            {
                if (selection == "1")
                {
                    exitchecker = true;
                    toolbox = true;
                }
                if (selection == "2")
                {
                    exitchecker = true;
                }
                else if(exitchecker == false)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

            }
            while (exitchecker == false);

            return toolbox;
        }


        private bool DroidComputerConnection()
        {
            bool exitchecker = false;
            bool computerConnection = false;
            Console.WriteLine("Will the Droid have a computer connection?");
            Console.WriteLine("1 = Yes");
            Console.WriteLine("2 = No");
            Console.Write("Selection: ");

            string selection = Console.ReadLine();
            do
            {
                if (selection == "1")
                {
                    exitchecker = true;
                    computerConnection = true;
                }
                if (selection == "2")
                {
                    exitchecker = true;
                }
                else if (exitchecker == false)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

            }
            while (exitchecker == false);

            return computerConnection;
        }

        private bool DroidScanner()
        {
            bool exitchecker = false;
            bool scanner = false;
            Console.WriteLine("Will the Droid have a scanner?");
            Console.WriteLine("1 = Yes");
            Console.WriteLine("2 = No");
            Console.Write("Selection: ");

            string selection = Console.ReadLine();
            do
            {
                if (selection == "1")
                {
                    exitchecker = true;
                    scanner = true;
                }
                if (selection == "2")
                {
                    exitchecker = true;
                }
                else if (exitchecker == false)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

            }
            while (exitchecker == false);

            return scanner;
        }

        private bool DroidBroom()
        {
            bool exitchecker = false;
            bool broom = false;
            Console.WriteLine("Will the Droid have a broom?");
            Console.WriteLine("1 = Yes");
            Console.WriteLine("2 = No");
            Console.Write("Selection: ");

            string selection = Console.ReadLine();
            do
            {
                if (selection == "1")
                {
                    exitchecker = true;
                    broom = true;
                }
                if (selection == "2")
                {
                    exitchecker = true;
                }
                else if (exitchecker == false)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

            }
            while (exitchecker == false);

            return broom;
        }

        private bool DroidVacuum()
        {
            bool exitchecker = false;
            bool vacuum = false;
            Console.WriteLine("Will the Droid have a vacuum?");
            Console.WriteLine("1 = Yes");
            Console.WriteLine("2 = No");
            Console.Write("Selection: ");

            string selection = Console.ReadLine();
            do
            {
                if (selection == "1")
                {
                    exitchecker = true;
                    vacuum = true;
                }
                if (selection == "2")
                {
                    exitchecker = true;
                }
                else if (exitchecker == false)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

            }
            while (exitchecker == false);

            return vacuum;
        }

        private bool DroidNavigation()
        {
            bool exitchecker = false;
            bool navigation = false;
            Console.WriteLine("Will the Droid have navigation?");
            Console.WriteLine("1 = Yes");
            Console.WriteLine("2 = No");
            Console.Write("Selection: ");

            string selection = Console.ReadLine();
            do
            {
                if (selection == "1")
                {
                    exitchecker = true;
                    navigation = true;
                }
                if (selection == "2")
                {
                    exitchecker = true;
                }
                else if (exitchecker == false)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

            }
            while (exitchecker == false);

            return navigation;
        }

        private int DroidNumberOfShips()
        {
            bool exitchecker = false;
            int droidNumberOfShips = 0;
            do
            {
                Console.WriteLine("How many ships will the Droid know how to operate?");
                Console.Write("Selection: ");

                droidNumberOfShips = int.Parse(Console.ReadLine());
                if(droidNumberOfShips >= 0)
                {
                    exitchecker=true;
                }
                if(droidNumberOfShips < 0)
                {
                    Console.WriteLine("Value must be greater than or equal to zero. Please try again.");
                }

            }
            while (exitchecker == false);


            return droidNumberOfShips;

        }

    }
}
