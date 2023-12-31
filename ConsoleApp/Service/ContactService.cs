using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using System.Diagnostics;

namespace ConsoleApp.Services;

public class ContactService : IContactService
{
    private readonly List<IContact> _contactList = new List<IContact>();

    public bool AddContactToList(IContact contact)
    {
        try
        {
            contact.Id = _contactList.Count + 1;

            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
}