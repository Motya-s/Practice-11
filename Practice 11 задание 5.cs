using System;

class Product
{
    private double price;
    private double discount;

    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                Console.WriteLine("Цена не может быть отрицательной");
            else
                price = value;
        }
    }

    public double Discount
    {
        get { return discount; }
        set
        {
            if (value < 0 || value > 100)
                Console.WriteLine("Скидка должна быть от 0 до 100%");
            else
                discount = value;
        }
    }

    public double FinalPrice => Price * (1 - Discount / 100);

    public string Name { get; set; } = "Без названия";

    public Product(double price, double discount)
    {
        Price = price;
        Discount = discount;
    }

    public void Show()
    {
        Console.WriteLine($"{Name}: {FinalPrice} (скидка {Discount}%)");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product p = new Product(1000, 20);
        p.Name = "Ноутбук";
        p.Show();

        p.Discount = 10;
        p.Show();

        p.Price = -50;
    }
}
