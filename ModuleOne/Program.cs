using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOne
{
    class Program
    {

        static void Main(string[] args)
        {
            //// 1 - Variable declaration & assignment
            //int x;
            //int y;
            //bool b;

            //x = 7;
            //y = x + 3;
            //b = false;

            //Console.WriteLine(y);
            //Console.WriteLine(b);


            //// 2 - Variable Initialisation
            //string myName = "Kyriacos";
            //Console.WriteLine(myName);
            //int myAge = 23;
            //Console.WriteLine(myAge);


            //// 3 - Var keyword
            //var number = 5;
            //var realNumber = 0.55;
            //var isPositive = false;
            //var myName = "Kyriacos";

            //myName = 10;
            //number = false;


            //// 4 - Console Input (string)
            //string favColor;
            //Console.Write("Enter your favorite colour: ");
            //favColor = Console.ReadLine();

            //Console.Write("Your favorite color is: ");
            //Console.Write(favColor);

            //// 5 - Console Input (number)            
            //int favNumber;
            //Console.Write("Enter your favorite number: ");
            //favNumber = int.Parse(Console.ReadLine());

            //Console.Write("Your favorite number is: ");
            //Console.Write(favNumber);

            //// 1 - Special Characters
            //string myString = "Go to your c:\ drive";
            //string myString = "My "so called" life";
            //string myString = "Words\tseparated\tby\ttabs";
            //string myString = "Words\nseparated\nby\nlines";
            //Console.WriteLine(myString);

            //// 2 - String concatenation         
            //string firstName = "Kyriacos";
            //string lastName = "Kyriacou";
            //string myString = firstName + " " + lastName;
            //Console.WriteLine(myString);

            //// 3 - Formatting Strings
            //string carMake = "Suzuki";
            //int carYear = 2004;

            //// 3.1 - Old way (string.Format)
            //string myString = string.Format("My car is a {0} and it was made in {1}", carMake, carYear);
            //string myString = string.Format("My car is a {0}. I love {0}", carMake);
            //Console.WriteLine(myString);

            //// 3.2 - New C#6 way (Interpolated string)
            //string myString = $"My car is {carMake} and it was made in {carYear}";
            //string myString = $"Curly braces {{ are used all the time in programming";
            //Console.WriteLine(myString);

            //// 4 - Formatting numeric results
            //// 4.1 - Currency
            //int myMoney = 50;
            //string myString = $"I currently have {myMoney:C}";
            //Console.WriteLine(myString);

            //// 4.2 - Numbers
            //int largeNumber = 1000000;
            //string myString = $"{largeNumber:N}";
            //Console.WriteLine(myString);

            //// 4.3 - Percentage
            //double success = 0.95;
            //string myString = $"{success:P}";
            //Console.WriteLine(myString);


            //// 5 - String Methods
            //string someString = "i should be in capitals";
            //string myString = someString.ToUpper();
            //string rawString = "The dog ran up the hill";
            //string myString = rawString.Replace(" ", "");
            //string userName = "  Joey123 ";
            //string myString = userName.Trim();
            //Console.WriteLine(myString);

            //// 1 - Conditional statements
            //int x = 5;
            //int y = 5;
            //if (x < y)
            //{
            //    Console.WriteLine("x smaller than y");
            //}
            //else if (x > y)
            //{
            //    Console.WriteLine("x bigger than y");
            //}
            //else
            //{
            //    Console.WriteLine("x is equal to y");
            //}

            //// 2 - Logical Operators
            //string username = "Username123";
            //string password = "Ron@ldo1";

            //if (username == password || password.Length < 8)
            //{
            //    Console.WriteLine("Please enter another password");
            //}

            //// 3 - Shorthand if (? operator)
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //    Console.WriteLine($"{num} is even");
            //else
            //    Console.WriteLine($"{num} is odd");
            //// Replaced by...
            //Console.WriteLine(num % 2 == 0 ? $"{num} is even" : $"{num} is odd");


            //// 4 - Conditionals on user input
            //Console.WriteLine("Pick door number 1, 2 or 3: ");
            //int userValue = int.Parse(Console.ReadLine());
            //if (userValue == 1)
            //{
            //    Console.WriteLine("You won a new car");
            //}
            //else if (userValue == 2)
            //{
            //    Console.WriteLine("You won a new boat");
            //}
            //else if (userValue == 3)
            //{
            //    Console.WriteLine("Too bad, you lost");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown option");
            //}

            //// 4.1 If -> switch
            //switch (userValue)
            //{
            //    case 1:
            //        Console.WriteLine("You won a new car");
            //        break;
            //    case 2:
            //        Console.WriteLine("You won a new boat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Too bad, you lost");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown option");
            //        break;
            //}

            //// 1 - Arrays(zero based!)
            //int[] numbers = new int[3];

            //numbers[0] = 5;
            //numbers[1] = 2;
            //numbers[2] = 10;

            //// 1.1 Shorthand way to initialise arrays
            // int[] numbers = new int[] { 5, 2, 10 };

            //Console.WriteLine(numbers[1]);

            //string[] names = { "John", "Mary", "Sue", "David" };

            //Console.WriteLine(names[2]);


            //// 2 - Lists adding & removing
            //List<string> names = new List<string>();
            //names.Add("John");
            //names.Add("Mary");
            //names.Add("Sue");
            //names.Add("David");

            //Console.WriteLine(names[2]);
            //Console.WriteLine(names.ElementAt(2));
            //Console.WriteLine(names.Count);

            //names.Remove("John");
            //names.RemoveAt(2);
            //Console.WriteLine(names.Count);
            //Console.WriteLine(names.IndexOf("David"));

            //// 2.1 Lists methods
            //List<double> grades = new List<double> { 90.5, 88, 70.5, 100, 60.5 };
            //grades.Sort();
            //Console.WriteLine(grades.First());
            //Console.WriteLine(grades.Last());
            //// 1 - For loop
            //var names = new string[] { "David", "Mary", "Sue" };
            //for (int i = 0; i < names.Length; ++i)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //// 2 - While loop
            //int sum = 1;
            //while (sum < 100)
            //{
            //    Console.WriteLine(sum);
            //    sum += sum;
            //}

            //// 3 - Do While Loop
            //int sum = 1;
            //do
            //{
            //    Console.WriteLine(sum);
            //    sum += sum;
            //} while (sum < 100);


            //// 4 - Foreach loop
            //var cars = new List<string> { "Suzuki", "BWM", "Mercedes", "Toyota", "Saab" };
            //for (int i = 0; i < cars.Count; ++i)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            //foreach (var car in cars)
            //{
            //    if (car.StartsWith("S"))
            //        Console.WriteLine(car);
            //}

            //// 4.1 - Index in foreach
            //var numbers = new List<int> { 5, 10, 32, 8, 2, 5, 32, 6, 2, 2 };
            //int count = 0;
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine($"Element at #{count}: {num}");
            //    ++count;
            //}

            //// 4.2 - Combining list methods with foreach
            //foreach (var num in numbers.Distinct())
            //{
            //    Console.WriteLine(num);
            //}

            Console.ReadLine();

        }
    }

  
    
}
