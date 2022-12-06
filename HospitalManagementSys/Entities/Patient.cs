using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSys.Entities
{
    public class Patient : Person
    {
        public int PatientId { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactNumber { get; set; }
        public string Adress { get; set; }
        public Patient(string cPF, string name, string adress, DateTime birthDate, char gender, string contactNumber, int patientId)
            : base(cPF, name, gender)
        {
            PatientId = patientId;
            ContactNumber = contactNumber;
            BirthDate = birthDate;
            Adress = adress;
        }
    }
}
