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

        public void AddProtocolDroid(string material, string color, int languages)
        {
            //Add protocol droid to the array of droids
            int index = NextAvailableSpot();
            droids[index] = new Protocol(material, color, languages);
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









