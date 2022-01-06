using System.Globalization;
using System.Runtime.CompilerServices;

namespace TestTask
{
    public class Car
    {
        public int Id { get;}
        public string Name { get; }
        public string Color { get; set; }
        public int Number { get; set; }

        public Car(int id, string name, string color, int number)
        {
            Id = id;
            Name = name;
            Color = color;
            Name = name;
        }
    }
}