using Android.Content;
using Android.Telephony;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileMedico.Models
{
    public class Repository
    {
       public string tokentwilio;
        public async Task<List<Doctor>> GetDoctor()
        {
            List<Doctor> doctor;
            var URLWebAPI = "http://doctorwebservice.azurewebsites.net/api/Doctor/Get";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                doctor = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Doctor>>(JSON);
            }
            return doctor;
        }


        public Doctor LogIn(Doctor doctor)
        {
            Doctor login;



            var URLWebAPI = "http://doctorwebservice.azurewebsites.net/api/Doctor/Login";
          
            var loginJson =  new   
                  {    doctor.EMAIL,
                       doctor.PASSWORD
                  };
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(loginJson);
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI).Result;
                login = Newtonsoft.Json.JsonConvert.DeserializeObject<Doctor>(JSON);

               
            }

            return login;

        }


        public List<Patient> GetPatientByDoctor(Doctor doctor)
        {

            List<Patient> patients;

            var URLWebAPI = "http://doctorwebservice.azurewebsites.net/api/1/Patient";
            //var URLWebAPI = "http://doctorwebservice.azurewebsites.net/api/"+doctor.ID_DOCTOR+"/Patient";

            var DoctorIdJson = new
            {
                doctor.ID_DOCTOR
            };
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(DoctorIdJson);
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI).Result;
                patients = Newtonsoft.Json.JsonConvert.DeserializeObject <List<Patient>>(JSON);


            }

            return patients;

        }

        public string GetTokeTwilio(string Identity, string deviceID)
        {
            Identity = "DR1";
            deviceID = Android.OS.Build.Serial.ToString();
            
            


            var URLWebAPI = "http://doctorwebservice.azurewebsites.net/api/GenerateChatToken" ;

            var TokenJson = new
            {
                Identity,
                deviceID
            };
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(TokenJson);
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = Client.GetStringAsync(URLWebAPI).Result;
                tokentwilio = Newtonsoft.Json.JsonConvert.DeserializeObject(JSON).ToString();


            }

            return tokentwilio;

        }
         

    }
}
