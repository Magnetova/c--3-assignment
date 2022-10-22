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
        const decimal COST_OF_ASTROMECH = 350;
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
            return $"Droid Type: Astromech{base.ToString()}/nNavigation: {Navigation}\nNumber of Ships: {NumberOfShips}";
        }
        //  CalculateTotalCost: Calculate totalCost by calculating the cost of each selected option and droid type. Then add those values  to any costs that can be calculated by the base class.
        public override void CalculateTotalCost()
        {
            decimal materialcost = 0;
            int additions = 0;
            if (Toolbox == true)
            {
                additions++;
            }
            if (ComputerConnection == true)
            {
                additions++;
            }
            if (Scanner == true)
            {
                additions++;
            }
            if (Navigation == true)
            {
                additions++;
            }

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

            TotalCost = materialcost + COST_OF_ASTROMECH + (additions * 30) + (COST_PER_SHIP * numberOfShips);
        }
    }
}
