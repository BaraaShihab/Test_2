namespace LibrarySystem;

public class Peron
{
    public int id { get; set; }
    public string name { get; set; }

    public Peron(int id, string name)
    {
        
        
        this.id = id;
        this.name = name;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {id}, Name: {name}");
    } 





    
    
}