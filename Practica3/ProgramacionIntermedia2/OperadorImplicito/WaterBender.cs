using System;

namespace ProgramacionIntermedia2.OperadorImplicito
{
    public class WaterBender : IBender
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Nation { get; set; }
        public bool IsHealer { get; set; }

        public WaterBender(string name, string gender, int age, bool isHealer)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Nation = "Northern Water Tribe";
            IsHealer = isHealer;
        }

        //Implicit operator that turns an airbender into a waterbender
        public static implicit operator WaterBender(AirBender airBender)
            => new WaterBender("Converted bender " + airBender.Name, airBender.Gender, airBender.Age, false);

        public void Bend()
        {
            Console.WriteLine($"{Name} made a water whip.");
        }

        public void Greet()
        {
            Console.WriteLine($"{Name} sends their regards from the {Nation}.");
        }

        public void Heal()
        {
            Console.WriteLine(IsHealer ? $"{Name} is healing someone." : $"{Name} is not a healer.");
        }
    }
}
