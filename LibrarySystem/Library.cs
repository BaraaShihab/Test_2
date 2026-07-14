namespace LibrarySystem;

public class Library
{
    public List<Book> Books { get; set; }

    public List<Peron> People { get; set; }


    public Library()
    {
        Books = new List<Book>();
        People = new List<Peron>();
    }


    public void AddBook(Book book)
    {
        Books.Add(book);
    }


    public void AddPerson(Peron person)
    {
        People.Add(person);
    }


    public void ShowBooks()
    {
        Console.WriteLine("Library Books:");

        foreach (Book book in Books)
        {
            book.DisplayInfo();
        }
    }


    public void ShowPeople()
    {
        Console.WriteLine("Library Members:");

        foreach (Peron person in People)
        {
            person.DisplayInfo();
        }
    }


    public Book? SearchBook(int id)
    {
        return Books.FirstOrDefault(
            b => b.Id == id
        );
    }


    public Peron? SearchPerson(string name)
    {
        return People.FirstOrDefault(
            p => p.name == name
        );
    }



    public void UpdateBook(int id, string newTitle, string newAuthor)
    {
        Book? book = SearchBook(id);
        if (book != null)
        {
            book.Title = newTitle;
            book.Author = newAuthor;
        }
    }

}