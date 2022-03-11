using System;

namespace ProgramacionIntermedia2.OperadorImplicito
{
    public class AirBender : IBender
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Nation { get; set; }
        public string BisonsName { get; set; }

        public AirBender(string name, string gender, int age, string bisonsName)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Nation = "Air Nomad Nation";
            BisonsName = bisonsName;
        }

        //Implicit operator that turns a waterbender into an airbender
        public static implicit operator AirBender(WaterBender waterBender)
            => new AirBender("Converted bender " + waterBender.Name, waterBender.Gender, waterBender.Age, "");

        public void Bend()
        {
            Console.WriteLine($"{Name} made a whirlwind.");
        }

        public void Greet()
        {
            Console.WriteLine($"{Name} sends their regards from the {Nation}.");
        }

        public void Fly()
        {
            Console.WriteLine(BisonsName != "" ? $"{Name} got on top of {BisonsName} and they flew away." : $"{Name} hasnt got a bison, so they flew using their glider.");
        }
    }
}
