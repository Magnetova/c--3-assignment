using System;

namespace cis237_assignment_3
{
    internal class DroidCollection
    {
        Droid[] droids = new Droid[100];
        public string CollectionToString()
        {
            string outputString = null;


            foreach (Beverage beverage in beverages)
            {
                if (beverage != null)
                {
                    // Concat to the outputstring
                    outputString += "|  " + beverage.Id.ToString().PadRight(13) + "|  " + beverage.Name.ToString().PadRight(60) + "|  " + beverage.Pack.ToString().PadRight(23) + "|  " + beverage.Price.ToString().PadRight(13) + "|  " + beverage.Active.ToString() +
                        Environment.NewLine;

                }
            }

            // Use the UI calss to print out the string
            return outputString;
        }
    }
}
