// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

namespace cis237_assignment_3
{
    internal class Protocol : Droid
    {
        //Variables: numberLanguages (int)

        private int numberLanguages;

        public int NumberLanguages
        {
            get { return numberLanguages; }
            set { numberLanguages = value; }
        }

        //Constant: costPerLanguage
        const decimal costPerLanguage = 100;

        //Constructors: 3 parameter constructor (string, string, int)
        //  Uses the base classs (Droid) constructor
        public Protocol(string Material, string Color, int NumberLanguages) : base(Material, Color)
        {
            this.numberLanguages = NumberLanguages;
        }
        public Protocol() { }

        //Public Methods:
        //  ToString:Return a formatted string containing the variables
        public override string ToString()
        {
            return $"{base.ToString()} {NumberLanguages.ToString("C")}";
        }

        //  CalculateTotalCost: Calculate the totalCost based on the number of languages and droid type. Then add those values to any      costs that can be calculated by the base class.

    }
}
