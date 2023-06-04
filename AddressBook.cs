using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    using System;
    using System.Collections.Generic;

    public class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void ListContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"First Name: {contact.FirstName}");
                Console.WriteLine($"Last Name: {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Zip: {contact.Zip}");
                Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine();
            }
            Contact GetContactByFirstName(string firstName)
            {
                return contacts.FirstOrDefault(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
            }

            bool DeleteContactByFirstName(string firstName)
            {
                Contact contactToDelete = GetContactByFirstName(firstName);
                if (contactToDelete != null)
                {
                    contacts.Remove(contactToDelete);
                    return true;
                }
                return false;
            }



        }

        internal bool DeleteContactByFirstName(string? firstName)
        {
            throw new NotImplementedException();
        }

        internal Contact GetContactByFirstName(string? firstName)
        {
            throw new NotImplementedException();
        }
    }
}
