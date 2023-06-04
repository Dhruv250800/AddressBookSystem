using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    using System;

    public class DeleteContactManager
    {
        public void DeleteContact(AddressBook addressBook)
        {
            Console.Write("Enter the first name of the contact to delete: ");
            string firstName = Console.ReadLine();

            bool contactDeleted = addressBook.DeleteContactByFirstName(firstName);
            if (contactDeleted)
            {
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found!");
            }
        }
    }
}
