using MobileMedico.Models;
using MobileMedico.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileMedico.Views
{
    public partial class HomePage : ContentPage
    {
        public ObservableCollection<HomeViewModel> patients { get; set; }
        public HomePage()
        {
            InitializeComponent();
            Repository repository = new Repository();
            Doctor doctor = new Doctor();
            var  predoctor=  Application.Current.Properties["DOCTOR"].ToString();
            List<Patient> patient = repository.GetPatientByDoctor(doctor);

            patients = new ObservableCollection<HomeViewModel>();

            foreach (var i in patients)
                patients.Add(new HomeViewModel { NamePatient = patient[0].Name, LastNamePatient = patient[0].Name, ImagePatient = "logo.png" });

            lstView.ItemsSource = patients;


           

        }



        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuPage());
        }

    }

}
