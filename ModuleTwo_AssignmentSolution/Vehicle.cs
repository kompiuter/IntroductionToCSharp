using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo_AssignmentSolution
{
    abstract class Vehicle
    {
        private string _plate;
        public string Plate
        {
            get { return _plate; }
            set { _plate = value.ToUpper(); }
        }

        public string Color { get; set; }
        public string Manufacturer { get; set; }

        public virtual void GetDetail(string plateNumber)
        {
            Plate = plateNumber;

            Console.WriteLine("Please enter the Manufacturer: ");
            Manufacturer = Console.ReadLine();

            Console.WriteLine("Please enter the Color: ");
            Color = Console.ReadLine();
        }

        public override string ToString()
        {
            return "Plate: " + Plate + Environment.NewLine
                   + "Manufaturer: " + Manufacturer + Environment.NewLine
                   + "Color: " + Color;
        }
    }
}
