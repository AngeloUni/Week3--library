using Week3Tutorials;


// // Instancing an Object without Constructor (Tutorial - 21T)
// // Creating an object
// Book book = new Book();
//
// // Creating attributes for class "book"
// book.Title = "C# for beginners";
// book.Author = "BillGates";
// book.ISBN = "12345678";
// book.DisplayInfo();
//
//
// // Creating a second object
// Book book1 = new Book();
// book.Title = "C# for beginners";
// book.Author = "Microsoft";
// book.ISBN = "55667778";
// book.DisplayInfo();





// // Instantiating an object with constructor (After Tutorial - 21T)
// Book book = new Book("C# for beginners", "BillGates", "12345678");
// book.DisplayInfo();


class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();
    }
}





