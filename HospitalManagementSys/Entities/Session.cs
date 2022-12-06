using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace HospitalManagementSys.Entities
{
    public class Session
    {
        public List<Doctor> OnDutyDoctors { get; } = new List<Doctor>();

        public void AddDoctor(Doctor doctor)
        {
            OnDutyDoctors.Add(doctor);
        }

        public void RemoveDoctor(int crm)
        {
            OnDutyDoctors.Remove(SelectDoctor(crm));
        }

        public void ListDoctors()
        {
            for (int i = 0; i < OnDutyDoctors.Count; i++)
            {
                Console.WriteLine("Doctor #" + (i+ 1));
                Console.WriteLine(OnDutyDoctors[i]);
                Console.WriteLine();
            }
        }

        public Doctor SelectDoctor(int crm)
        {
            Doctor doctor = new Doctor();

            try
            {
                doctor = OnDutyDoctors.Find(x => x.CRM == crm);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error! The CRM typed doesn't match with any doctor in system!");
            }

            return doctor;
        }
    }
}
