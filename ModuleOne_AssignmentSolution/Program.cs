using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOne_AssignmentSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            string carPlate;

            var AllCarPlates = new List<string>();


            do
            {

                // Main Menu 
                // Note:
                //  - Environment.NewLine is equivalent of "\n"
                //    it is a dynamic alternative which works everywhere
                //  - You can often break long pieces of code into multiple lines
                Console.WriteLine("> My Parking Program <" +
                                  Environment.NewLine + "1) Add Car Plate" +
                                  Environment.NewLine + "2) Remove Car Plate" +
                                  Environment.NewLine + "3) Show All Car Plates!" +
                                  Environment.NewLine + "4) Exit");

                do
                {
                    Console.Write("> ");
                    userChoice = int.Parse(Console.ReadLine());
                } while (userChoice < 1 || userChoice > 4);

                Console.WriteLine();

                switch (userChoice)
                {
                    // Add Car Plate
                    case 1:
                        Console.WriteLine("Please enter the new car plate: ");

                        // Get input in capital format (Since car plates are capital)
                        carPlate = Console.ReadLine().ToUpper();

                        var exists = AllCarPlates.Contains(carPlate);

                        if (exists)
                            Console.WriteLine($"You have already added \"{carPlate}\" to the parking.");
                        else
                        {
                            AllCarPlates.Add(carPlate);
                            Console.WriteLine($"\"{carPlate}\" has been added to the parking.");
                        }

                        break;

                    // Remove Car Plate
                    case 2:
                        Console.WriteLine("Please enter a car plate you wish to remove: ");

                        // Get input in capital format (Since car plates are capital)
                        carPlate = Console.ReadLine().ToUpper();

                        // Since the Remove function returns bool,
                        // indicating whether an entry has been removed,
                        // we don't need to separately check if the given plate is removed.
                        if (AllCarPlates.Remove(carPlate))
                            Console.WriteLine($"\"{carPlate}\" has been removed from the parking.");
                        else
                            Console.WriteLine($"\"{carPlate}\" was not found in the parking.");

                        break;

                    // Show All Car Plates
                    case 3:

                        Console.WriteLine("Cars currently parked in the parking");

                        foreach (var plate in AllCarPlates)
                            Console.WriteLine(" > " + plate);

                        break;
                }

                // Like System("Pause") from C++
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();

                // Clears the console Like System("cls") in C++
                Console.Clear();
                
            } while (userChoice != 4);
        }
    }
}
