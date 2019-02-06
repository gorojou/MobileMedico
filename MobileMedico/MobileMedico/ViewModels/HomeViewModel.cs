using MobileMedico.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileMedico.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {

        private Doctor _user;
        public Doctor User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }

        public string NamePatient { get; set; }
        public string LastNamePatient { get; set; }

        public string ImagePatient { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName]
            string propertyName = null) =>
                PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        public Command ToolbarItemCommand { get; private set; }
        private bool Busy;
        public bool IsBusy
        {
            get
            {
                return Busy;
            }
            set
            {
                Busy = value;
                OnPropertyChanged();
                ToolbarItemCommand.ChangeCanExecute();
            }
        }
    }
}
