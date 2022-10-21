namespace cis237_assignment_3
{
    abstract class Droid : IDroid
    {
        //--------------------------
        // No Constants
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        //--------------------------
        // Variables
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        private string material;
        private string color;
        private decimal totalCost;
        private decimal materialCost;

        //--------------------------
        // Properties
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

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
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = materialCost; }
        }
        public decimal MaterialCost
        {
            get { return materialCost; }
        }

        //--------------------------
        // Public Methods
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        public override string ToString()
        {
            return $"{material} {color} {totalCost}";
        }

        public decimal CalculateMaterialCost()
        {
            if (material == "1")
            {
                return 50;
            }
            if (material == "2")
            {
                return 500;
            }
            if (material == "3")
            {
                return 750;
            }
            else
            {
                return 0;
            }
        }

        public void CalculateTotalCost()
        {
            return;
        }
        //--------------------------
        // Protected Methods
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        //--------------------------
        // Constructors
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        public Droid(string Material, string Color)
        {
            this.material = Material;
            this.color = Color;
        }

        public Droid() { }
    }
}
