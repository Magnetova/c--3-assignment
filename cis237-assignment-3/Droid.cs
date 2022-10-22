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

        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public virtual decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }

        }


        //Constructors: 2 parameter constructor (string, string)

        public Droid(string Material, string Color)
        {
            this.material = Material;
            this.color = Color;
        }


        //Public Methods:
        // ToString: return a formatted string containing the properties of the droid.
        public override string ToString()
        {
            return $"Material: {Material}\nColor: {Color}";
        }

        // CalculateTotalCost: Required by the interface to calculate and store the total cost.

        public virtual void CalculateTotalCost() 
        {
        }

        //Protected Methods:
        //My Choice


    }
}
