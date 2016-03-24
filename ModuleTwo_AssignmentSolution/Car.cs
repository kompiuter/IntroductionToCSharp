using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo_AssignmentSolution
{
    class Car : Vehicle
    {
        public bool IsSport { get; set; }

        public override void GetDetail(string plateNumber)
        {
            base.GetDetail(plateNumber);

            Console.WriteLine("Is it a sport car? (true/false) ");
            IsSport = bool.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine
                   + "Is Sport? " + (IsSport ? "Yes" : "No");
        }
    }
}
