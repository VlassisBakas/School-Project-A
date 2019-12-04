using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Draft
{
    class AssignmentPerCourse
    {
        public List<Assignment> Assignments { get; set; }
        public Course Course { get; set; }
        public AssignmentPerCourse()
        {

        }


        public AssignmentPerCourse(Course course)
        {
            Assignments = new List<Assignment>();
            Course = course;
        }
        public void OutputAssignmentPerCourse()
        {

            Course.OutputCourse();
            Console.WriteLine("Assignments in the course: ");
            foreach (var item in Assignments)
            {
                item.OutputAssignment();
            }



        }
        public void InputAssignmentPerCourse()
        {
            Console.WriteLine("Enter a Course: ");
            Course.InputCourse();
            Console.WriteLine("How many assignments has this course?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the assignments: ");
            for (int i = 0; i < a; i++)
            {
                Assignment k = new Assignment();
               k.InputAssignment();
                Assignments.Add(k);
            }
        }
    }
}
