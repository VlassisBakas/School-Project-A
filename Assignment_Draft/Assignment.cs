using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Draft
{
    public class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        public Assignment()
        {

        }

        public Assignment(string title, string description, DateTime subdatetime, int oralmark, int totalmark)
        {
            Title = title;
            Description = description;
            SubDateTime = subdatetime;
            OralMark = oralmark;
            TotalMark = totalmark;
        }


        public void OutputAssignment()
        {
            Console.WriteLine($"{Title,-12}|{Description,-15}|{SubDateTime.ToString("dd/MM/yyyy"),-12}|{OralMark,-10}|{TotalMark,-10}");
        }
        public void InputAssignment()
        {
            InputTitle();
            InputDescription();
            InputSubDateTime();
            InputOralMark();
            InputTotalMark();
        }
        public void InputTitle()
        {
            Console.WriteLine("Enter Title: ");
            Title = Console.ReadLine();
        }
        public void InputDescription()
        {
            Console.WriteLine("Enter Description: ");
            Description = Console.ReadLine();
        }
        public void InputSubDateTime()
        {
            Console.WriteLine("Enter SubDateTime: ");
            SubDateTime = Convert.ToDateTime(Console.ReadLine());
        }
        public void InputOralMark()
        {
            Console.WriteLine("Enter OralMark: ");
            OralMark = Convert.ToInt32(Console.ReadLine());
        }
        public void InputTotalMark()
        {
            Console.WriteLine("Enter TotalMark: ");
            TotalMark = Convert.ToInt32(Console.ReadLine());
        }



    }
}
