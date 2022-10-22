// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

namespace cis237_assignment_3
{
    internal class Utility : Droid
    {
        //Variables: toolbox (bool), computerConnection (bool), scanner (bool)
        private bool toolbox;
        private bool computerConnection;
        private bool scanner;
        

        public bool Toolbox
        {
            get { return toolbox; }
            set { toolbox = value; }
        }
        public bool ComputerConnection
        {
            get { return computerConnection; }
            set { computerConnection = value; }
        }
        public bool Scanner
        {
            get { return scanner; }
            set { scanner = value; }
        }

        const decimal COST_OF_UTILITY = 250;

        //Constructors: 5 parameter constructor (string, string, bool, bool, bool) 
        //  Uses the base class (Droid) constructor

        public Utility(string Material, string Color, bool Toolbox, bool ComputerConnection, bool Scanner) : base(Material, Color)
        {
            this.toolbox = Toolbox;
            this.computerConnection = ComputerConnection;
            this.scanner = Scanner;
        }

        //Public Methods: 
        //  ToString: return a formatted string containing the variables
        public override string ToString()
        {
            return $"Droid Type: Utility\n{base.ToString()}\nToolbox: {Toolbox}\nComputer Connection: {ComputerConnection}\nScanner: {Scanner}";
        }
        //  CalculateTotalCost: Calculates totalCost by calculating the cost of each selected option and droid type. Then add those        values to any costs that can be calculated by the base class.
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

            TotalCost = materialcost + COST_OF_UTILITY + (additions * 30);
        }
    }
}
