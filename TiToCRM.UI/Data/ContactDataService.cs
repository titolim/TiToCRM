using System.Collections.Generic;
using TiToCRM.Model;

namespace TiToCRM.UI.Data
{
    public class ContactDataService : IContactDataService
    {
        public IEnumerable<Contact> GetAll()
        {
            yield return new Contact { FirstName = "Tito", LastName = "Lim" };
            yield return new Contact { FirstName = "Ali", LastName = "Nebbar" };
            yield return new Contact { FirstName = "François", LastName = "Rocheleau" };
            yield return new Contact { FirstName = "Bill", LastName = "Gates" };
        }
    }
}