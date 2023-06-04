using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to AddressBookSystem ");
        AddressBook addressBook = new AddressBook();
        EditContactManager editContactManager = new EditContactManager();
        DeleteContactManager deleteContactManager = new DeleteContactManager();

        Console.WriteLine("Address Book Application");
        Console.WriteLine("------------------------");

        while (true)
        {
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. List Contacts");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid choice! Please enter a valid integer.");
                Console.WriteLine();
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the contact details:");
                    Contact newContact = new Contact();
                    Console.Write("First Name: ");
                    newContact.FirstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    newContact.LastName = Console.ReadLine();
                    Console.Write("Address: ");
                    newContact.Address = Console.ReadLine();
                    Console.Write("City: ");
                    newContact.City = Console.ReadLine();
                    Console.Write("State: ");
                    newContact.State = Console.ReadLine();
                    Console.Write("Zip: ");
                    newContact.Zip = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    newContact.PhoneNumber = Console.ReadLine();
                    Console.Write("Email: ");
                    newContact.Email = Console.ReadLine();

                    addressBook.AddContact(newContact);
                    Console.WriteLine("Contact added successfully!");
                    break;

                case 2:
                    editContactManager.EditContact(addressBook);
                    break;

                case 3:
                    deleteContactManager.DeleteContact(addressBook);
                    break;

                case 4:
                    Console.WriteLine("List of Contacts:");
                    addressBook.ListContacts();
                    break;

                case 5:
                    Console.WriteLine("Exiting the program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}