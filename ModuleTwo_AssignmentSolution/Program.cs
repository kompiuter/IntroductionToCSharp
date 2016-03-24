using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo_AssignmentSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            var Vehicles = new List<Vehicle>();

            do
            {
                // Main Menu 
                // Note:
                //  - Environment.NewLine is equivalent of "\n"
                //    it is a dynamic alternative which works everywhere
                //  - You can often break long pieces of code into multiple lines
                Console.WriteLine("> My Parking Program V2.0 <" +
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
                    // Add New Vehicle
                    case 1:
                        TryAddVehicle(Vehicles);
                        break;

                    // Remove Vehicle (by Plate)
                    case 2:
                        TryRemoveVehicle(Vehicles);
                        break;

                    // Show All Vehicles
                    case 3:
                        DisplayAllVehicles(Vehicles);
                        break;
                }

                // Like System("Pause") from C++
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                // Clears the console Like System("cls") in C++
                Console.Clear();

            } while (userChoice != 4);
        }

        private static void TryRemoveVehicle(List<Vehicle> Vehicles)
        {
            string vehiclePlate;
            Console.WriteLine("Please enter a car plate you wish to remove: ");

            // Get input in capital format (Since car plates are capital)
            vehiclePlate = Console.ReadLine().ToUpper();

            bool isRemoved = false;

            // Note that you cannot use foreach
            // because if you change the collection inside foreach, it would crash!
            for (int i = 0; i < Vehicles.Count; ++i)
                if (Vehicles[i].Plate == vehiclePlate)
                {
                    Vehicles.RemoveAt(i);
                    isRemoved = true;
                    break;
                }

            if (isRemoved)
                Console.WriteLine($"\"{vehiclePlate}\" has been removed from the parking.");
            else
                Console.WriteLine($"\"{vehiclePlate}\" was not found in the parking.");
        }

        private static void TryAddVehicle(List<Vehicle> Vehicles)
        {
            Console.WriteLine("Please enter the new vehicle plate: ");

            var newPlate = Console.ReadLine();

            foreach (var veh in Vehicles)
                if (veh.Plate == newPlate)
                {
                    Console.WriteLine($"You have already added \"{newPlate}\" to the parking.");
                    return;
                }

            string vehicleType;
            do
            {
                Console.WriteLine("Please enter your vehicle type: (Car/Truck/Vehicle)");
                // to lower, to avoid case sensitivity
                vehicleType = Console.ReadLine().ToLower();
            }
            while (vehicleType != "car" && vehicleType != "truck" && vehicleType != "bike");

            Vehicle newVehicle;

            if (vehicleType == "car")
                newVehicle = new Car();
            else if (vehicleType == "truck")
                newVehicle = new Truck();
            else // if it's a Bike 
                newVehicle = new Bike();

            newVehicle.GetDetail(newPlate);

            Vehicles.Add(newVehicle);
            Console.WriteLine("Following vehicle has been added to the parking:" + Environment.NewLine +
                              newVehicle.ToString());
        }

        private static void DisplayAllVehicles(List<Vehicle> Vehicles)
        {
            Console.WriteLine("Vehicles currently parked in the parking");

            foreach (var vehicle in Vehicles)
            {
                if (vehicle is Car)
                    Console.WriteLine("[Car]:");
                else if (vehicle is Truck)
                    Console.WriteLine("[Truck]:");
                else if (vehicle is Bike)
                    Console.WriteLine("[Bike]:");

                Console.WriteLine(vehicle.ToString() + Environment.NewLine);
            }
        }
    }
}
