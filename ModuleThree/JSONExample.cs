using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    class JSONExample
    {
        public static void Run()
        {
            //// 1 - Serializing into json string
            //var myTruck = new Car { Type = "Truck", Wheels = 6, Colors = new string[] { "Red", "Green", "Blue" } };

            //string jsonString = JsonConvert.SerializeObject(myTruck);
            //File.WriteAllText("output.json", jsonString);


            // 2 - Deserialize from json string
            //string jsonString = File.ReadAllText("objectExample1.json");
            //var myCar = JsonConvert.DeserializeObject<Car>(jsonString);

            //Console.WriteLine($"Type: {myCar.Type}");
            //Console.WriteLine($"Wheels: {myCar.Wheels}");
            //Console.WriteLine("Colors: ");
            //foreach (var color in myCar.Colors)
            //    Console.Write($"{color} ");

            //// 3 - Deserialize complex object
            //string jsonString = File.ReadAllText("schoolData.json");
            //var school = JsonConvert.DeserializeObject<School>(jsonString);

            //Console.WriteLine(school.courses[0].students[1].name);


            //// 4 - Use Case (storing user input)
            //string jsonString = File.ReadAllText("userCars.txt");
            //List<Car> cars = new List<Car>();
            //if (!string.IsNullOrWhiteSpace(jsonString))
            //    cars = JsonConvert.DeserializeObject<List<Car>>(jsonString);

            //int input;
            //do
            //{
            //    input = ShowMenu();
            //    switch (input)
            //    {
            //        case 1:
            //            Console.Clear();
            //            Console.WriteLine("Enter car details...");
            //            Console.Write("Type: ");
            //            string type = Console.ReadLine();

            //            cars.Add(new Car { Type = type });

            //            string json = JsonConvert.SerializeObject(cars);
            //            File.WriteAllText("userCars.txt", json);

            //            Console.WriteLine("Car successfully added!");
            //            break;
            //        case 2:
            //            Console.Clear();
            //            foreach (var car in cars)
            //                Console.WriteLine(car.Type);
            //            break;
            //        default:
            //            break;
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Press any key to continue...");
            //    Console.ReadLine();

            //} while (input != 3);
        }

        static int ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("1 - Add car");
            Console.WriteLine("2 - View all cars");
            Console.WriteLine("3 - Exit");

            return int.Parse(Console.ReadLine());
        }
    }

    class Car
    {
        public string Type { get; set; }
        public int Wheels { get; set; }

        // Can also use List<string>
        public string[] Colors { get; set; }
    }

    class School
    {
        public string name { get; set; }
        public string address { get; set; }
        public Course[] courses { get; set; }
    }

    class Course
    {
        public string subject { get; set; }
        public Teacher teacher { get; set; }
        public Student[] students { get; set; }
    }

    class Teacher
    {
        public string name { get; set; }
        public int age { get; set; }
        public bool isPresent { get; set; }
    }

    class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public bool isPresent { get; set; }
    }
}
