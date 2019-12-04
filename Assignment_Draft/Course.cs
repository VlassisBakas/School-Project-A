using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Draft
{
    public class Course
    {
        
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Course()
        {
            
        }


        public Course(string title, string stream, string type, DateTime startdate, DateTime enddate)
        {
            Title = title;
            Stream = stream;
            Type = type;
           StartDate =startdate;
            EndDate = enddate;

        }

        public void OutputCourse()
        {
            Console.WriteLine($"{Title,-12}|{Stream,-15}|{Type,-12}|{StartDate.ToString("dd/MM/yyyy"),-12}|{EndDate.ToString("dd/MM/yyyy"),-12}");
        }

        public void InputTitle()
        {
            Console.WriteLine("Enter Title: ");
            Title=Console.ReadLine();
        }
        public void InputStream()
        {
            Console.WriteLine("Enter Stream: ");
           Stream= Console.ReadLine();
        }
        public void InputType()
        {
            Console.WriteLine("Enter Type: ");
            Type=Console.ReadLine();
        }
        public void InputStartDate()
        {
            Console.WriteLine("Enter start date: ");
            StartDate= Convert.ToDateTime(Console.ReadLine());
        }
        public void InputEndDate()
        {
            Console.WriteLine("Enter End Date: ");
            EndDate = Convert.ToDateTime(Console.ReadLine());
        }
        public void InputCourse()
        {
            InputTitle();
            InputStream();
            InputType();
            InputStartDate();
            InputEndDate();
            
        }
    }
}

