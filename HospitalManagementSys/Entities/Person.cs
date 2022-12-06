using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSys.Entities
{
    public class Person
    {
        public string CPF { get; private set; }
        public string Name { get; set; }
        public char Gender { get; private set; }

        public Person()
        {

        }
        public Person(string cPF, string name, char gender)
        {
            CPF = cPF;
            Name = name;
            Gender = gender;
        }

        //public Person NewPerson()
        //{
        //    Console.Write("Name: ");
        //    string name = Console.ReadLine();
        //    Console.Write("CPF: ");
        //    string cpf = Console.ReadLine();
        //    Console.Write("Gender (M/F): ");
        //    char gender = Convert.ToChar(Console.ReadLine());

        //    return new Person(cpf, name, gender);
        //}
    }
}
