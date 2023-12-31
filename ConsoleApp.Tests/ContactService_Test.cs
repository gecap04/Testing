using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using ConsoleApp.Services;
using System.Collections.Generic;

namespace ConsoleApp.TestProject;

public class ContactService_Test
{
    [Fact]
    public void AddContactToListShould_AddOneContactToContactList_ThenReturnTrue()
    {
        ///Arrange
        IContact contact = new Contact { Name = "Gustav", LastName = "Klaesson", PhoneNumber = "07312345", Email = "gustavdomain.com" };
        IContactService contactService = new ContactService();

        ///Act
        bool result = contactService.AddContactToList(contact);

        ///Assert
        Assert.True(result);
    }
}