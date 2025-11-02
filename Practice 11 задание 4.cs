using System;

class Player
{
    private int level;
    private int health;

    public int Level
    {
        get { return level; }
        set
        {
            if (value < 1 || value > 100)
                Console.WriteLine("Уровень должен быть от 1 до 100!");
            else
                level = value;
        }
    }

    public int Health
    {
        get { return health; }
        set
        {
            if (value < 0)
                health = 0;
            else if (value > 100)
                health = 100;
            else
                health = value;
        }
    }

    public string Name { get; init; } //Испоьзовал private set для проверки т.к код не робит с init

    public bool IsAlive => Health > 0;

    public Player(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        string aliveText = IsAlive ? "да" : "нет";
        Console.WriteLine($"Игрок: {Name}, уровень: {Level}, здоровье: {Health}, жив: {aliveText}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player p = new Player("Alex", 5, 70);
        p.TakeDamage(30);
        p.TakeDamage(40);
        p.Level = 0;
    }
}
