using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    internal class UserInterface
    {
        public int PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Load File");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Search List");
            Console.WriteLine("4. Add New Beverage");
            Console.WriteLine("5. Exit");
            Console.Write("Select Option: ");
            int choice = this.GetUserInput();
            Console.WriteLine();

            return choice;
        }
    }
}
