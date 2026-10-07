namespace Week3Tutorials;

public class Book
{
    public string Title;
    public string Author;
    public string ISBN;

    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        this.Title = bookTitle;
        this.Author = bookAuthor;
        this.ISBN = bookISBN;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }


}