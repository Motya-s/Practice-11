using System;

class Book
{
    private string title;

    public string Title
    {
        get { return title; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Название не может быть пустым!");
            }
            else
            {
                title = value;
            }
        }
    }

    public int Pages { get; set; } = 1; 

    public bool IsLong => Pages > 300; 

    public Book(string title)
    {
        Title = title;
    }

    public void Info()
    {
        string longText = IsLong ? "да" : "нет";
        Console.WriteLine($"Книга: {Title}, страниц: {Pages}, длинная: {longText}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Шерлок холмс");
        book1.Pages = 1000;
        book1.Info();

        Book book2 = new Book("");
        book2.Info();
    }
}