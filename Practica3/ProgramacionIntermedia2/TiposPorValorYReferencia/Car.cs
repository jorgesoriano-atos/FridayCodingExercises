using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIntermedia2.TiposPorValorYReferencia
{
    public class CarClass
    {
        public double Price { get; set; }
        public string Color { get; set; }
        public int DoorNumber { get; set; }
        public CarClass(double price, string color, int doorNumber)
        {
            Price = price;
            Color = color;
            DoorNumber = doorNumber;
        }
    }

    public struct CarStruct
    {

        public double Price { get; set; }
        public string Color { get; set; }
        public int DoorNumber { get; set; }
        public CarStruct(double price, string color, int doorNumber)
        {
            Price = price;
            Color = color;
            DoorNumber = doorNumber;
        }

    }
}
