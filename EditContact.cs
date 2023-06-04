using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    using System;

    public class EditContactManager
    {
        public void EditContact(AddressBook addressBook)
        {
            Console.Write("Enter the first name of the contact to edit: ");
            string firstName = Console.ReadLine();

            Contact contact = addressBook.GetContactByFirstName(firstName);
            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            Console.WriteLine("Enter the new contact details:");
            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("City: ");
            contact.City = Console.ReadLine();
            Console.Write("State: ");
            contact.State = Console.ReadLine();
            Console.Write("Zip: ");
            contact.Zip = Console.ReadLine();
            Console.Write("Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Contact updated successfully!");
        }
    }
}
