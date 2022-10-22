// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

using System;

namespace cis237_assignment_3
{
    internal class UserInterface
    {

        public void PrintList()
        {
            //Print the list from the concat string
        }

        public void AddNewDroid(DroidCollection droidCollection)
        {
            //Collect user input for droid and pass to droid collection class
            string droidType = "";

            System.Console.WriteLine("What type of droid would you like to add?");
            System.Console.WriteLine("1. Protocol");
            System.Console.WriteLine("2. Utility");
            System.Console.WriteLine("3. Janitor");
            System.Console.WriteLine("4. Astromech");

            droidType = Console.ReadLine();

            if (droidType == "1")
            {
                //create protocol droid

                //get material
                string material = DroidMaterial();
                //get color
                string color = DroidColor();
                //get number of languages
                int languages = DroidNumberOfLanguages();

                droidCollection.AddProtocolDroid(material, color, languages);

            }
            if (droidType == "2")
            {
                //create Utility droid
            }
            if (droidType == "3")
            {
                //create Janitor droid
            }
            if (droidType == "4")
            {
                //create Astromech droid
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

        }

        private string DroidMaterial()
        {
            string droidMaterial = "";
            System.Console.WriteLine("What type of material will the droid be made out of?");
            System.Console.WriteLine("1. Aluminum");
            System.Console.WriteLine("2. Gold");
            System.Console.WriteLine("3. Platinum");
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
            System.Console.WriteLine("What type of material will the droid be made out of?");
            System.Console.WriteLine("1. Black");
            System.Console.WriteLine("2. White");
            System.Console.WriteLine("3. Yellow");
            droidColor = Console.ReadLine();

            if (droidColor == "1")
            {
                return "Black";
            }
            if (droidColor == "2")
            {
                return "White";
            }
            if (droidColor == "3")
            {
                return "Yellow";
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
                return "";
            }

        }

        private int DroidNumberOfLanguages()
        {
            int droidNumberOfLanguages = 0;
            Console.WriteLine("How many languages will this droid know?");
            droidNumberOfLanguages = int.Parse(Console.ReadLine());

            return droidNumberOfLanguages;

        }


    }
}
