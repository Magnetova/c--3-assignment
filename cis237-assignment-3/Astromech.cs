// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

namespace cis237_assignment_3
{
    internal class Astromech : Utility
    {
        //Variables: navigation (bool), numberShips (int)
        private bool navigation;
        private int numberOfShips;

        public bool Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }
        public int NumberOfShips
        {
            get { return numberOfShips; }
            set { numberOfShips = value; }
        }

        //Constant: costPerShip
        const decimal COST_PER_SHIP = 250;
        //Constructors: 7 parameter constructor (string, string, bool, bool, bool, bool, int) 
        //  Uses the base class (Utility) constructor

        public Astromech(string Material, string Color, bool Toolbox, bool ComputerConnection, bool Scanner, bool Navigation, int NumberShips) : base(Material, Color, Toolbox, ComputerConnection, Scanner)
        {
            this.navigation = Navigation;
            this.numberOfShips = NumberShips;
        }

        //Public Methods: 
        //  ToString: return a formatted string containing the variables

        public override string ToString()
        {
            return $"{base.ToString()} {Navigation} {NumberOfShips}";
        }
        //  CalculateTotalCost: Calculate totalCost by calculating the cost of each selected option and droid type. Then add those values  to any costs that can be calculated by the base class.
    }
}
