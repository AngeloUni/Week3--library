namespace Week3Tutorials;


// // Tutorial 21T to 24T (Before Learning Encapsulation
// public class Book
// {
//     public string Title;
//     public string Author;
//     public string ISBN;
//
//     public Book(string bookTitle, string bookAuthor, string bookISBN)
//     {
//         this.Title = bookTitle;
//         this.Author = bookAuthor;
//         this.ISBN = bookISBN;
//     }
//     
//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Book Title: {Title}");
//         Console.WriteLine($"Author: {Author}");
//         Console.WriteLine($"Book ISBN: {ISBN}");
//         Console.WriteLine();
//     }
//
//
// }






// // Tutorial 25T First Half (Learning Encapsulation)
// public class Book
// {
//     
//     // Field needs to be lowercased, so the properties can be uppercased
//     private string title;
//     private string author;
//     private string isbn;
//
//     
//     // Title property allows access
//     // to the title private field
//     public string Title
//     {
//         get { return title; }  // get method
//         set { title = value; } // set method
//     }
//     public string Author
//     {
//         get { return author; }
//         set { author = value; }
//     }
//     public string ISBN
//     {
//         get { return isbn; }
//         set { isbn = value; }
//     }
//     
//     public Book(string bookTitle, string bookAuthor, string bookISBN)
//     {
//         this.Title = bookTitle;
//         this.Author = bookAuthor;
//         this.ISBN = bookISBN;
//     }
//     
//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Book Title: {Title}");
//         Console.WriteLine($"Author: {Author}");
//         Console.WriteLine($"Book ISBN: {ISBN}");
//         Console.WriteLine();
//     }
//
//     
//     
//     public string Author
// {
//     get { return author; }
//     set 
//     { 
//         // Checks if any character in the incoming string is a digit
//         if (!value.Any(char.IsDigit))
//         {
//             author = value;
//         }
//         else
//         {
//             Console.WriteLine("Error: Author name cannot contain numbers.");
//         }
//     }
// }
//  
// public string ISBN
// {
//     get { return isbn; }
//     set 
//     { 
//         // Checks that the incoming string is not blank
//         if (value != "") 
//         {
//             isbn = value; 
//         }
//         else
//         {
//             Console.WriteLine("Error: ISBN cannot be blank.");
//         }
//     }
// }




// Tutorial 25T Second Half (Learning Encapsulation, Adding Validation Rules)
public class Book
{
    
    // Field needs to be lowercased, so the properties can be uppercased
    private string title;
    private string author;
    private string isbn;

    
    // Title property allows access
    // to the title private field
    public string Title
    {
        get { return title; }  // get method
        set { title = value; } // set method
    }
    public string Author
    {
        get { return author; }
        set 
        { 
            // Checks if any character in the incoming string is a digit
            if (!value.Any(char.IsDigit))
            {
                author = value;
            }
            else
            {
                Console.WriteLine("Error: Author name cannot contain numbers.");
            }
        }
    }
    
    public string ISBN
    {
        get { return isbn; }
        set 
        { 
            // Checks that the incoming string is not blank
            if (value != "") 
            {
                isbn = value; 
            }
            else
            {
                Console.WriteLine("Error: ISBN cannot be blank.");
            }
        }
    }
    
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
    
    
    
    
    

 
