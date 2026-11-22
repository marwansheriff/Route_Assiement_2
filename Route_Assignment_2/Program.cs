// Q1

using System.Text;
Console.WriteLine();
Console.WriteLine("Q1");
Console.WriteLine();
String s1 = "hello world";
String s2 = s1.ToUpper();
Console.WriteLine("normal string: "+s1);
Console.WriteLine("upper case string: "+s2);


// Q2
Console.WriteLine();
Console.WriteLine("Q2");
Console.WriteLine();
String s3 = "Clean Code";
String s4 = "Clean Code";
Console.WriteLine(ReferenceEquals(s3, s4));

// Q3
Console.WriteLine();
Console.WriteLine("Q3");
Console.WriteLine();
StringBuilder sb = new StringBuilder("Book List");
sb.Append(" - Updated");
Console.WriteLine("StringBuilder: "+sb);

// Q4
Console.WriteLine();
Console.WriteLine("Q4");
Console.WriteLine();
sb.Replace("Book List", "Library");
Console.WriteLine("StringBuilder after replace: "+sb);

// Q5
Console.WriteLine();
Console.WriteLine("Q5");
Console.WriteLine();
string title = "Clean Code";
int pages = 464;

Console.WriteLine("Book: "+title+", Pages: "+pages);

// Q6
Console.WriteLine();
Console.WriteLine("Q6");
Console.WriteLine();
Console.WriteLine($"Book: {title}, Pages: {pages}");

// Q7
Console.WriteLine();
Console.WriteLine("Q7");
Console.WriteLine();
Console.WriteLine("Book: {0}, Pages: {1}", title, pages);

///////////////////////

Book b1 = new Book("Clean Code", 464, true);
Book b2 = new Book("The Pragmatic Programmer", 299, false);
Book b3 = new Book("Refactoring", 448, true);
////////////////////////

// Q8
Console.WriteLine();
Console.WriteLine("Q8");
Console.WriteLine();

Console.WriteLine(b1.BookSize());
Console.WriteLine(b2.BookSize());

// Q9
Console.WriteLine();
Console.WriteLine("Q9");
Console.WriteLine();

Console.WriteLine(b1.AvailableToBorrow());
Console.WriteLine(b2.AvailableToBorrow());

// Q10
Console.WriteLine();
Console.WriteLine("Q10");
Console.WriteLine();

Console.WriteLine(b1.ChoiceAssist());
Console.WriteLine(b3.ChoiceAssist());
Console.WriteLine(b2.ChoiceAssist());

// Q11
Console.WriteLine();
Console.WriteLine("Q11");
Console.WriteLine();

Console.WriteLine(b1.BookSizeTernary());
Console.WriteLine(b2.BookSizeTernary());

// Q12
Console.WriteLine();
Console.WriteLine("Q12");
Console.WriteLine();

 string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

for(int i =1; i <= books.Length; i++)
{
    Console.WriteLine($"Book {i}: {books[i-1]}");
}

// Q13
Console.WriteLine();
Console.WriteLine("Q13");
Console.WriteLine();
int whileindex = 0;
while( whileindex < books.Length)
{
    Console.WriteLine(books[whileindex]);
    whileindex++;
}

// Q14
Console.WriteLine();
Console.WriteLine("Q14");
Console.WriteLine();
whileindex = 0;
do 
{
    Console.WriteLine("Checking book...");
    whileindex++;
} while (whileindex < books.Length);

// Q15
Console.WriteLine();
Console.WriteLine("Q15");
Console.WriteLine();

foreach (string book in books)
{
    Console.WriteLine(book);
}

// Q16
Console.WriteLine();
Console.WriteLine("Q16");
Console.WriteLine();
foreach (string book in books)
{
    if (book == "Refactoring")
    {
        Console.WriteLine("Found the book!");
        break;
    }
    Console.WriteLine(book);
}

// Q17
Console.WriteLine();
Console.WriteLine("Q17");
Console.WriteLine();

foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
    {
        Console.WriteLine("Skipping this book.");
        continue;
    }
    Console.WriteLine(book);
}

// Q18
Console.WriteLine();
Console.WriteLine("Q18");
Console.WriteLine();

string PrintFirstBook(string[] books)
{
    if (books.Length > 0)
    {
        return books[0];
    }
    return "";
}

Console.WriteLine(PrintFirstBook(books));



public class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string title, int pages, bool isAvailable)
    {
        Title = title;
        Pages = pages;
        IsAvailable = isAvailable;
    }

    public string BookSize()
    {
        if (Pages > 300)
        {
            return "Long Book";
        }
        else
        {
            return "Short Book";
        }
    }

    public string AvailableToBorrow()
    {
        if (IsAvailable && Pages > 300)
        {
            return "You can borrow this book";
        }
        else
        {
            return "This book is not available for borrowing";
        }
    }

    public string ChoiceAssist()
    {
        switch (Title)
        {
            case "Clean Code":
                return "Great choice!";
            case "Refactoring":
                return "Nice pick!";
            default:
                return "Never heard of it";
        }
    }

    public string BookSizeTernary()
    {
        return Pages > 300 ? "Long Book" : "Short Book";
    }

    public override string ToString()
    {
        return $"Book: {Title}, Pages: {Pages}, Available: {IsAvailable}";
    }
}