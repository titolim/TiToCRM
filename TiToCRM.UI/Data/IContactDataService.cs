using System.Collections.Generic;
using TiToCRM.Model;

namespace TiToCRM.UI.Data
{
    public interface IContactDataService
    {
        IEnumerable<Contact> GetAll();
    }
}