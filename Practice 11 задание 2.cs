using System;

class Phone
{
    private int battery; 

    public int BatteryLevel
    {
        get { return battery; }
        set
        {
            if (value < 0)
                battery = 0;
            else if (value > 100)
                Console.WriteLine("Заряд не может превышать 100!");
            else
                battery = value;
        }
    }

    public string Brand { get; init; } //Испоьзовал private set для проверки т.к код не робит с init

    public Phone(string brand, int battery)
    {
        Brand = brand;
        BatteryLevel = battery;
    }

    public void Use()
    {
        BatteryLevel = Math.Max(0, BatteryLevel - 10);
        Console.WriteLine($"{Brand}: заряд {BatteryLevel}%.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Phone phone = new Phone("Poco", 80);
        phone.Use();
        phone.Use();
        phone.Use();

        phone.BatteryLevel = 150; 
    }
}