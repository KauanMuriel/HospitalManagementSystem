using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSys.Entities
{
    public class Doctor : Person
    {
        public int CRM { get; }
        internal bool InBreak = false;

        public Doctor()
        {

        }

        public Doctor(int cRM)
        {
            CRM = cRM;
        }

        public Doctor(int cRM, string cPF, string name, char gender) : base(cPF, name, gender)
        {
            CRM = cRM;
        }

        public void DoctorStartingBreak()
        {
            InBreak = true;
        }

        public void DoctorArrivingBreak()
        {
            InBreak = false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("CRM: ");
            sb.AppendLine(CRM.ToString());
            sb.Append("Name: ");
            sb.AppendLine(Name);

            return sb.ToString();
        }
    }
}
