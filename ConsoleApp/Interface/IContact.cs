namespace ConsoleApp.Interfaces;

public interface IContact
{
    int Id { get; set; }
    string Name { get; set; }
    string LastName { get; set; }
    string PhoneNumber { get; set; }
    string Email { get; set; }
   
}
