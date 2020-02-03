using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGurin
{
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("В аэропорту нет свободных мест")
        { }
    }
}