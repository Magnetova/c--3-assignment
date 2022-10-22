// Cayden Greer
// CIS 237 - Fall 2022
// 10-21-2022

namespace cis237_assignment_3
{
    abstract class Droid : IDroid
    {
        //Variables: material (string), color (string), totalCost (decimal)
        protected private string material;
        protected private string color;
        protected private decimal totalCost;

        public abstract string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public decimal TotalCost
        {
            get { return totalCost; }
            set
            {
                if (material == "1")


                }
        }


        //Constructors: 2 parameter constructor (string, string)

        public Droid(string Material, string Color)
        {
            this.material = Material;
            this.color = Color;
        }

        //Property: TotalCost to return the cost of the droid (Required by the interface)


        //Public Methods:
        // ToString: return a formatted string containing the properties of the droid.
        public override string ToString()
        {
            return $"{material} {color}";
        }

        // CalculateTotalCost: Required by the interface to calculate and store the total cost.

        public void CalculateTotalCost() { }

        //Protected Methods:
        //My Choice

    }
}
