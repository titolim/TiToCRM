using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TiToCRM.Model;
using TiToCRM.UI.Data;

namespace TiToCRM.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IContactDataService _contactDataService;
        private Contact _selectedontact;

        public MainViewModel(IContactDataService contactDataService)
        {
            this.Contacts = new ObservableCollection<Contact>();
            _contactDataService = contactDataService;
        }

        public void Load()
        {
            var contacts = _contactDataService.GetAll();

            this.Contacts.Clear();
            foreach (var contact in contacts)
            {
                this.Contacts.Add(contact);
            }
        }

        public ObservableCollection<Contact> Contacts { get; set; }

        public Contact SelectedContact
        {
            get { return _selectedontact; }
            set
            {
                _selectedontact = value;
                OnPropertyChanged();
            }
        }
    }
}