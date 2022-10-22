// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

using System;

namespace cis237_assignment_3
{
    internal class DroidCollection
    {
        Droid[] droids = new Droid[100];

        private int NextAvailableSpot()
        {
            for(int i = 0; i < droids.Length; i++)
            {
                if(droids[i] == null)
                {
                    return i;
                }
            }
            Console.WriteLine("No free space available in the array.");
            return 101;
        }

        public void AddProtocolDroid(string Material, string Color, int Languages)
        {
            //Add protocol droid to the array of droids
            int index = NextAvailableSpot();
            droids[index] = new Protocol(Material, Color, Languages);
        }


        public void AddUtilityDroid(string Material, string Color, bool Toolbox, bool ComputerConnection, bool Scanner)
        {
            //Add protocol droid to the array of droids
            int index = NextAvailableSpot();
            droids[index] = new Utility(Material, Color, Toolbox, ComputerConnection, Scanner);
        }


        public void AddJanitorDroid(string Material, string Color, bool Toolbox, bool ComputerConnection, bool Scanner, bool Broom, bool Vacuum)
        {
            //Add protocol droid to the array of droids
            int index = NextAvailableSpot();
            droids[index] = new Janitor(Material, Color, Toolbox, ComputerConnection, Scanner, Broom, Vacuum);
        }


        public void AddAstromechDroid(string Material, string Color, bool Toolbox, bool ComputerConnection, bool Scanner, bool Navigation, int NumberShips)
        {
            //Add protocol droid to the array of droids
            int index = NextAvailableSpot();
            droids[index] = new Astromech(Material, Color, Toolbox, ComputerConnection, Scanner, Navigation, NumberShips);
        }


        public string CollectionToString()
        {
            string outputString = null;

            foreach (Droid droid in droids)
            {
                if(droid != null)
                {
                    outputString += droid.ToString() + Environment.NewLine;
                }
            }
            return outputString;
        }
    }

}









