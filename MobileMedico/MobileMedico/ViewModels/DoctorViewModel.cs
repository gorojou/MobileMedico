using MobileMedico.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileMedico.ViewModels
{
    public class DoctorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName]
            string propertyName = null) =>
                PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));

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
                GetDoctorCommand.ChangeCanExecute();
            }
        }
        public ObservableCollection<Doctor> Doctor { get; set; }
        public DoctorViewModel()
        {
            Doctor = new ObservableCollection<Doctor>();
            GetDoctorCommand = new Command(
                async () => await GetDoctor(),
                () => !IsBusy
                );
        }
        public async Task GetDoctor()
        {
            if (!IsBusy)
            {
                Exception Error = null;
                try
                {
                    IsBusy = true;
                    var Repository = new Repository();
                    var Items = await Repository.GetDoctor();
                    Doctor.Clear();
                    foreach (var user in Items)
                    {
                        Doctor.Add(user);
                    }
                }
                catch (Exception ex)
                {
                    Error = ex;
                }
                finally
                {
                    IsBusy = false;
                }
                if (Error != null)
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert(
                    "Error!", Error.Message, "OK");
                }

            }
            return;
        }
        public Command GetDoctorCommand { get; set; }
    }
}
