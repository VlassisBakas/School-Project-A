using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Draft
{
    public class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject;
        public Trainer()
        {

        }

        public Trainer(string firstname, string lastname, string subject)
        {
            FirstName = firstname;
            LastName = lastname;
            Subject = subject;
        }

        public void OutputTrainer()
        {
            Console.WriteLine($"{FirstName,-12}|{ LastName,-15}| {Subject,-12}");

        }        
        public void InputTrainer()
        {
            InputFirstName();
            InputLastName();
            InputSubject();
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
        public void InputSubject()
        {
            Console.WriteLine("Enter Subject: ");
            Subject = Console.ReadLine();
        }
    }

}
