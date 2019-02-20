using System;
using ContactsApp.iOS;
using Xamarin.Forms;
using Foundation;

[assembly: Dependency(typeof(Contact))]
namespace ContactsApp.iOS
{
    public class Contact : IContact
    {
        public Contact()
        {
        }

        public string ByeContact()
        {
            ContactsLibraryiOS.ContactsApp contact = new ContactsLibraryiOS.ContactsApp((NSString)"Richard", (NSString)"Cummings", (NSString)"ysl@example.com");
            return contact.ByeContact();
        }

        public string HelloContact()
        {
            ContactsLibraryiOS.ContactsApp contact = new ContactsLibraryiOS.ContactsApp((NSString)"Richard", (NSString)"Cummings", (NSString)"ysl@example.com");
            return contact.GreetContact();
        }
    }
}
