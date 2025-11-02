using System;

class Car
{
    private int speed; 

    public int Speed  
    {
        get { return speed; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Скорость не может быть отрицательной!");
            }
            else if (value > 300)
            {
                Console.WriteLine("Скорость не может превышать 300!");
            }
            else
            {
                speed = value;
            }
        }
    }

    public string Model { get; init; } = "Unknown"; // Испоьзовал private set для проверки т.к код не робит с init 

    public Car(string model, int speed) 
    {
        Model = model;
        Speed = speed;
    }

    public void Drive() 
    {
        Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Audi", 150);
        car.Drive();

        car.Speed = 400; // превышает 300
        car.Drive();

        car.Speed = -50; // отрицательная
    }
}