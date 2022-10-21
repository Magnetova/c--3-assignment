using System;

namespace cis237_assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (choice != 3)
            {
                DroidCollection droidCollection = new DroidCollection();
                UserInterface userInterface = new UserInterface();
                int choice = userInterface.PrintMenu();

                if (choice == 1)
                {
                    userInterface.PrintList(droidCollection.CollectionToString());
                }
                if (choice == 2)
                {
                    droidCollection.AddNewDroid(userInterface.NewDroid(droidCollection));
                    Console.WriteLine("\n\nNew beverage has been added!");
                }

                Console.WriteLine("\n\n\n");
                choice = userInterface.PrintMenu();
            }


            return;

        }
    }
}
