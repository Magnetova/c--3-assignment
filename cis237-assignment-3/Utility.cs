using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    internal class Utility : Droid
    {
        //--------------------------
        // Variables
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        private bool toolbox;
        private bool computerConnection;
        private bool scanner;


        //--------------------------
        // Constructors
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        public Utility(string Material, string Color, bool ToolBox, bool ComputerConnection, bool Scanner) : base(Material, Color)
        {
            this.toolbox = ToolBox;
            this.computerConnection = ComputerConnection;
            this.scanner = Scanner;
            
        }

        public Utility()
        {

        }




        //--------------------------
        // Public Methods
        //VVVVVVVVVVVVVVVVVVVVVVVVVV


    }
}
