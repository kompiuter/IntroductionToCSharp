using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo_AssignmentSolution
{
    class Bike : Vehicle
    {
        bool IsElectric { get; set; }

        public override void GetDetail(string plateNumber)
        {
            base.GetDetail(plateNumber);

            Console.WriteLine("Is it an electric bike? (true/false) ");
            IsElectric = bool.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine
                   + "Is Electric? " + (IsElectric ? "Yes" : "No");
        }
    }
}
