using ConsoleApp.Interfaces;

namespace ConsoleApp.Models;

public class Contact : IContact
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    
}