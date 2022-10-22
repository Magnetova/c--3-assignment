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

            droidType = Console.ReadLine();

            do
            {
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
                    exitchecker = true;
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
                else if (droidType != "1" && droidType != "2" && droidType != "3" && droidType != "4")
                {
                    Console.WriteLine("Invalid option.");
                }
            }
            while (exitchecker = false);

        }

        private string DroidMaterial()
        {
            string droidMaterial = "";
            Console.WriteLine("What type of material will the droid be made out of?");
            Console.WriteLine("1. Aluminum");
            Console.WriteLine("2. Gold");
            Console.WriteLine("3. Platinum");
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
            Console.WriteLine("What color will the droid be?");
            Console.WriteLine("1. Black");
            Console.WriteLine("2. White");
            Console.WriteLine("3. Yellow");
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
                    exitchecker=!true;
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
            int droidNumberOfLanguages = 0;
            Console.WriteLine("How many languages will this droid know?");
            droidNumberOfLanguages = int.Parse(Console.ReadLine());

            return droidNumberOfLanguages;

        }


    }
}
