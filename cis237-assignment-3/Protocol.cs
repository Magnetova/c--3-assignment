namespace cis237_assignment_3
{
    internal class Protocol : Droid
    {
        //--------------------------
        // Constants
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        const decimal COST_PER_LANGUAGE = 100;

        //--------------------------
        // Variables
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        private int numberLanguages;

        //--------------------------
        // Properties
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        public int NumberLanguages
        {
            get { return numberLanguages; }
            set { numberLanguages = value; }
        }

        //--------------------------
        // Public Methods
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        public override string ToString()
        {
            return $"{base.ToString()} {numberLanguages.ToString("C")}";
        }

        public decimal CalculateTotalCost()
        {
            return (numberLanguages * COST_PER_LANGUAGE) + (base.CalculateTotalCost);
        }

        //--------------------------
        // Protected Methods
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        //--------------------------
        // Constructors
        //VVVVVVVVVVVVVVVVVVVVVVVVVV

        public Protocol(
            string Material,
            string Color,
            int NumberLanguages
            ) : base(Material, Color)
        {
            this.numberLanguages = NumberLanguages;
        }
    }
}
