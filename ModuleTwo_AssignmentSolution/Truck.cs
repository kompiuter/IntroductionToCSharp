using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo_AssignmentSolution
{
    class Truck : Vehicle
    {
        public int WheelCount { get; set; }

        public override void GetDetail(string plateNumber)
        {
            base.GetDetail(plateNumber);

            Console.WriteLine("Please enter the number of wheels: ");
            WheelCount = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine
                   + "Wheel Count: " + WheelCount;
        }
    }
}
