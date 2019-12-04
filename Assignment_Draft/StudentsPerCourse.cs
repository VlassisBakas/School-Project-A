using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Draft
{
    class StudentsPerCourse
    {
        public List<Student>Students { get; set; }
        public Course Course { get; set; }

        

        public StudentsPerCourse()
        {
            Course = new Course();
            Students = new List<Student>();


        }
        
        public StudentsPerCourse(Course course)
        {
            Course =course;
            Students = new List<Student>();


        }
        public void OutputStudentsPerCourse()
        {

            Course.OutputCourse();
            Console.WriteLine("Students in the course: ");
            foreach (var item in Students)
            {
                item.OutputStudent();
            }


            
        }
        public void InputStudentPerCourse()
        {
            Console.WriteLine("Enter a Course: ");
            Course.InputCourse();
            Console.WriteLine("How many student belong to this course?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Students: ");
            for (int i = 0; i < a; i++)
            {
                Student s = new Student();
                s.InputStudent();
                Students.Add(s);
            }
        }
    }
}
