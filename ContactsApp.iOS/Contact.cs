using System;
using ContactsApp.iOS;
using Xamarin.Forms;
using Foundation;

[assembly: Dependency(typeof(Contact))]
namespace ContactsApp.iOS
{
    [Preserve(AllMembers = true)]
    public class Contact : IContact
    {
        [Preserve(Conditional = false)]
        public Contact()
        {
            // code that we want to preserve
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
