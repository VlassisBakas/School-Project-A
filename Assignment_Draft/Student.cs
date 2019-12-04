using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Draft
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        public Student()
        {
                
        }

        public Student(string firstname, string lastname, DateTime dateofbirth, int tuitionfees)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
            TuitionFees = tuitionfees;
        }

        public void OutputStudent()
        {
            
            Console.WriteLine($"{FirstName,-12}|{LastName,-15}|{DateOfBirth,-12}|{ TuitionFees,-5}");
            
            
        }

        public  void InputStudent()
        {
            InputFirstName();
            InputLastName();
            InputDateOfBirth();
            InputTuitionFees();
        }

        public void InputFirstName()
        {
            Console.WriteLine("Enter First Name: ");
            FirstName = Console.ReadLine();
        }
        public void InputLastName()
        {
            Console.WriteLine("Enter Last Name: ");
            LastName = Console.ReadLine();
        }
        public void InputDateOfBirth()
        {
            Console.WriteLine("Enter Date Of Birth: ");
            DateOfBirth =Convert.ToDateTime(Console.ReadLine());

        }
        public void InputTuitionFees()
        {
            Console.WriteLine("Enter tuition fees: ");
            TuitionFees = Convert.ToInt32(Console.ReadLine());
        }

    }
}
