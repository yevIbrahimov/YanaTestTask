using System.Collections.Generic;

namespace TestTask
{
    enum StatusCode
    {
        Success = 200,
        Failed = 400
    }

    public class Server
    {
        private static List<Car> _cars = new List<Car>()
        {
            new Car(1, "Ford", "Black", 1234),
            new Car(2, "Nissan", "White", 2345),
            new Car(3, "Mazda", "Red", 3456),
            new Car(4, "Lexus", "Red", 4567),
            new Car(5, "Toyota", "Yellow", 5678),
            new Car(6, "Tesla", "White", 6789),
            new Car(7, "Infinity", "Black", 7890),
            new Car(8, "Ford", "Black", 1357),
            new Car(9, "Tesla", "Gray", 2468),
            new Car(10, "Tesla", "Gray", 1111)
        };

        
    }
}