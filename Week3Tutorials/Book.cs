namespace Week3Tutorials;

public class Book
{
    public string Title;
    public string Author;
    public string ISBN;

    public void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }
}