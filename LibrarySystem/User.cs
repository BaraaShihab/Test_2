namespace LibrarySystem;

public class User: Peron


{
    public List<Book> BorrowedBooks { get; set; }
    
    public User(int id, string name)
        : base(id, name)
    {
       
        BorrowedBooks = new List<Book>();
    }
    
   
    
}