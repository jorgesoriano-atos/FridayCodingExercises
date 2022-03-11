using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIntermedia2.OperadorImplicito
{
    public static class BenderTester
    {
        public static void DoAirBenderThings(AirBender airBender)
        {
            airBender.Greet();
            airBender.Bend();
            airBender.Fly();
            Console.WriteLine("\n");
        }
        public static void DoWaterBenderThings(WaterBender waterBender)
        {
            waterBender.Greet();
            waterBender.Bend();
            waterBender.Heal();
            Console.WriteLine("\n");
        }
    }
}
