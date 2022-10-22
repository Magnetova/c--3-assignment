// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

namespace cis237_assignment_3
{
    internal class Protocol : Droid
    {
        //Variables: numberOfLanguages (int)

        private int numberOfLanguages;

        public int NumberOfLanguages
        {
            get { return numberOfLanguages; }
            set { numberOfLanguages = value; }
        }

        //Constant: costPerLanguage
        const decimal COST_PER_LANGUAGE = 100;
        const decimal COST_OF_PROTOCOL = 200;


        //Constructors: 3 parameter constructor (string, string, int)
        //  Uses the base classs (Droid) constructor
        public Protocol(string Material, string Color, int NumberOfLanguages) : base(Material, Color)
        {
            this.numberOfLanguages = NumberOfLanguages;
        }

        //Public Methods:
        //  ToString:Return a formatted string containing the variables
        public override string ToString()
        {
            return $"Droid Type: Protocol\n{base.ToString()}\nNumber of Languages: {NumberOfLanguages.ToString()}";
        }

        //  CalculateTotalCost: Calculate the totalCost based on the number of languages and droid type. Then add those values to any      costs that can be calculated by the base class.

        public override void CalculateTotalCost()
        {
            decimal materialcost = 0;
            if (Material == "Aluminum")
            {
                materialcost = 50;
            }
            if (Material == "Gold")
            {
                materialcost = 500;
            }
            if (Material == "Platinum")
            {
                materialcost = 750;
            }

            TotalCost = materialcost + COST_OF_PROTOCOL + (COST_PER_LANGUAGE * numberOfLanguages);
        }
    }
}
