namespace LibrarySystem;

public class Librarian : Peron
{
    public string EmployeeNumber { get; set; }


    public Librarian(int id, string name, string employeeNumber)
        : base(id, name)
    {
        EmployeeNumber = employeeNumber;
    }


    public override void DisplayInfo()
    {
        Console.WriteLine(
            $"Librarian: {name}, Employee No: {EmployeeNumber}"
        );
    }
}