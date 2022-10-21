using System;

namespace cis237_assignment_3
{
    internal class UserInterface
    {
        public int PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Add New Beverage");
            Console.WriteLine("3. Exit");
            Console.Write("Select Option: ");
            int choice = this.GetUserInput();
            Console.WriteLine();

            return choice;
        }

        public int GetUserInput()
        {

            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                this.PrintErrorMessage();

                this.PrintMenu();

                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }

        public void PrintList(string outputList)
        {
            Console.WriteLine(outputList);
            return;
        }

        public Droid NewDroid(DroidCollection droidCollection)
        {
            Droid newDroid = new Protocol();
        }
        
        private void PrintErrorMessage()
        {
            Console.WriteLine("This is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();

        }



    }
}
