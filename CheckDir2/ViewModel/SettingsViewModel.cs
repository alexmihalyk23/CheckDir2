using CheckDir2.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDir2.ViewModel
{
    public class SettingsViewModel : ViewModelBase
    {
        private ObservableCollection<Settings> _settingsCollection = new ObservableCollection<Settings>();

        public ObservableCollection<Settings> SettingsCollection
        {
            get { return _settingsCollection; }
            set { Set(() => SettingsCollection, ref _settingsCollection, value); }
        }
        public SettingsViewModel()
        {
            SettingsCollection.Add(new Settings() { PathToFolder = "afaf", DaysLimit =5, StartTime = DateTime.Now });
        }
    }
}
