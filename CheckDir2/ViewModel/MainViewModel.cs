using CheckDir2.Model;
using CheckDir2.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using System;
using System.Security.Permissions;
using System.Windows;

namespace CheckDir2.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>

        private string directoryPath;
        

        public string DirectoryPath
        {
            get { return directoryPath; }
            set {
                Console.WriteLine(value);
                Set(()=> DirectoryPath, ref directoryPath, value); 
            }
        }

        //public RelayCommand ShowDir { get; private set; }
        public RelayCommand OpenSettings { get; private set; }

        public MainViewModel()
        {
            //ShowDir = new RelayCommand(() => MessageBox.Show("agag"), ()=> true);
            OpenSettings = new RelayCommand(()=>ShowSettings(), ()=>true);
        }
        

        private void ShowSettings()
        {
            new Views.SettingsView().Show();
        }
    }
}