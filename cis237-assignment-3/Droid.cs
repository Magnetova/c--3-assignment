using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    internal class Droid
    {
        //--------------------------
        // Constants
        //VVVVVVVVVVVVVVVVVVVVVVVVVV


        //--------------------------
        // Variables
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        protected string material;
        protected string color;
        protected decimal totalCost;

        //--------------------------
        // Constructors
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        public Droid(string Material, string Color)
        {
            this.material = Material;
            this.color = Color;
        }

        //--------------------------
        // Properties
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        private decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }


        //--------------------------
        // Public Methods
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        public override string ToString()
        {
            return material + " " + color + " " + totalCost;
        }

        public decimal CalculateTotalCost()
        {
            return totalCost;
        }

        //--------------------------
        // Protected Methods
        //VVVVVVVVVVVVVVVVVVVVVVVVVV
    }
}
