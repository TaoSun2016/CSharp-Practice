using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class HondaCar:Car
    {
        public string GetRegisterNumber()
        {
            return RegisterNumber;
        }

        public int GetWindowsNumber()
        {
            return Windows;
        }
        public int GetWheelsNumber()
        {
            return Wheels;
        }
        public int GetSeatsNumber()
        {
            return Seats;
        }
    }
}
