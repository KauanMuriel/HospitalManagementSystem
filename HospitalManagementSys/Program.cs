using HospitalManagementSys.Entities;

namespace HospitalManagementSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mainProgram = true;

            Session session = new Session();

            Console.WriteLine("    * HOSPITAl QUEENS * ");
            Console.Write("Quantity of on duty doctors: ");
            int onDuty = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < onDuty; i++)
            {
                Console.Write("CRM: ");
                int crm = Convert.ToInt32(Console.ReadLine());

                Doctor doctor = new Doctor(crm);
                session.AddDoctor(doctor);
            }

            while (mainProgram)
            {

                Console.Clear();

                Console.WriteLine("    * HOSPITAl QUEENS * ");
                Console.WriteLine("1.Update on duty doctors");
                Console.WriteLine("2.Add new patient record");
                Console.WriteLine("3.Add diagnosis information");
                Console.WriteLine("4.Full history of patient");
                Console.WriteLine("5.Hospital information");
                Console.WriteLine("6.Exit");

                Console.WriteLine();
                Console.WriteLine("- On duty doctors: ");
                Console.WriteLine();
                session.ListDoctors();

                int optionChoosen = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (optionChoosen)
                {
                    case 1:

                        bool onDutyScreen = true;

                        while (onDutyScreen)
                        {
                            Console.Clear();
                            session.ListDoctors();

                            Console.WriteLine();
                            Console.WriteLine("1.Add a doctor");
                            Console.WriteLine("2.Remove a doctor");
                            Console.WriteLine("3.Doctor starting a break");
                            Console.WriteLine("4.Doctor arriving from break");
                            Console.WriteLine("5.Return");
                            int OnDutyOption = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            int crm = 0;
                            
                            if (OnDutyOption != 5)
                            {
                                Console.Write("CRM: ");
                                crm = Convert.ToInt32(Console.ReadLine());
                            }

                            switch (OnDutyOption)
                            {
                                case 1:
                                    session.AddDoctor(new Doctor(crm));
                                    break;
                                case 2:
                                    session.RemoveDoctor(crm);
                                    break;
                                case 3:
                                    session.SelectDoctor(crm).DoctorStartingBreak();
                                    break;
                                case 4:
                                    session.SelectDoctor(crm).DoctorArrivingBreak();
                                    break;
                                case 5:
                                    onDutyScreen = false;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        mainProgram = false;
                        break;
                }
            }
        }
    }
}