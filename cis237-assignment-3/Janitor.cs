// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

namespace cis237_assignment_3
{
    internal class Janitor : Utility
    {
        //Variables: broom (bool), vacuum (bool)
        private bool broom;
        private bool vacuum;

        public bool Broom
        {
            get { return broom; }
            set { broom = value; }
        }
        public bool Vacuum
        {
            get { return vacuum; }
            set { vacuum = value; }
        }


        //Constructors: 7 parameter constructor (string, string, bool, bool, bool, bool, bool) 
        //  Uses the base class (Utility) constructor

        public Janitor(string Material, string Color, bool Toolbox, bool ComputerConnection, bool Scanner, bool Broom, bool Vacuum) : base(Material, Color, Toolbox, ComputerConnection, Scanner)
        {
            this.broom = Broom;
            this.vacuum = Vacuum;
        }

        //Public Methods: 
        //  ToString: return a formatted string containing the variables
        public override string ToString()
        {
            return $"{base.ToString()} {Broom} {Vacuum}";
        }
        //  CalculateTotalCost: Calculate totalCost by calculating the cost of each selected option and droid type. Then add those values  to any costs that can be calculated by the base class.
    }
}
