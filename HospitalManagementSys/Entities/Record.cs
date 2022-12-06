using HospitalManagementSys.Entities.Enums;

namespace HospitalManagementSys.Entities
{
    public class Record
    {
        public Patient Patient { get; }
        public Doctor Doctor { get; }
        public string Symptons { get; set; }
        public string Diagnosis { get; set; }
        public string Medicines { get; set; }
        public ManchesterTriage EmergencyLevel { get; set; }

        public Record(Patient patient, Doctor doctor, string symptons, string diagnosis, string medicines, ManchesterTriage emergencyLevel)
        {
            Patient = patient;
            Doctor = doctor;
            Symptons = symptons;
            Diagnosis = diagnosis;
            Medicines = medicines;
            EmergencyLevel = emergencyLevel;
        }
    }
}
