using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Assignment_Draft
{
    static class Input
    {
        public static void InputData()
        {

            Console.WriteLine("How many are the courses? ");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            List<Course> courses = new List<Course>();
            List<Student> students = new List<Student>();
            List<Trainer> trainers = new List<Trainer>();
            List<Assignment> assignments = new List<Assignment>();
            List<StudentsPerCourse> studentspercourse = new List<StudentsPerCourse>();
            List<TrainerPerCourse> trainerpercourse = new List<TrainerPerCourse>();
            List<AssignmentPerCourse> assignmentpercourse = new List<AssignmentPerCourse>();
            List<AssignmentPerStudent> assignmentperstudent = new List<AssignmentPerStudent>();
            while (i < x)
            {

                Course c = new Course();
                c.InputCourse();
                courses.Add(c);
                StudentsPerCourse sc = new StudentsPerCourse(c);

                TrainerPerCourse tc = new TrainerPerCourse(c);

                AssignmentPerCourse ac = new AssignmentPerCourse(c);


                Console.WriteLine("How many trainers has this course? (Please enter a number)");
                int y = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < y; j++)
                {
                    Trainer t = new Trainer();
                    t.InputTrainer();
                    trainers.Add(t);
                    tc.Trainers.Add(t);
                    trainerpercourse.Add(tc);
                }
                Console.WriteLine("How many assignments has this course? (Please enter a number)");
                int z = Convert.ToInt32(Console.ReadLine());
                for (int k = 0; k < z; k++)
                {
                    Assignment a = new Assignment();
                    a.InputAssignment();
                    assignments.Add(a);
                    ac.Assignments.Add(a);
                    assignmentpercourse.Add(ac);
                }
                Console.WriteLine("How many students has this course? (Please enter a number)");
                int b = Convert.ToInt32(Console.ReadLine());
                for (int l = 0; l < b; l++)
                {
                    Student s = new Student();
                    s.InputStudent();
                    students.Add(s);
                    sc.Students.Add(s);
                    AssignmentPerStudent AS = new AssignmentPerStudent(s);
                    AS.AssignmentsPerCourse.Add(ac);
                    assignmentperstudent.Add(AS);
                    studentspercourse.Add(sc);

                }

                i++;

            }
            Console.WriteLine("The students are:");
            Console.WriteLine(" ");
            foreach (var item in students)
            {
                item.OutputStudent();
            }
            Console.WriteLine(" ");
            Console.WriteLine("The courses are:");
            Console.WriteLine(" ");
            foreach (var item in courses)
            {
                item.OutputCourse();
            }
            Console.WriteLine(" ");
            Console.WriteLine("The trainers are:");
            Console.WriteLine(" ");
            foreach (var item in trainers)
            {
                item.OutputTrainer();
            }
            Console.WriteLine(" ");
            Console.WriteLine("The assignments are:");
            Console.WriteLine(" ");
            foreach (var item in assignments)
            {
                item.OutputAssignment();
            }
            Console.WriteLine(" ");
            Console.WriteLine("The students per courses are:");
            Console.WriteLine(" ");
            foreach (var item in studentspercourse)
            {
                item.OutputStudentsPerCourse();
            }
            Console.WriteLine(" ");
            Console.WriteLine("The trainers per courses are:");
            Console.WriteLine(" ");
            foreach (var item in trainerpercourse)
            {
                item.OutputTrainerPerCourse();
            }
            Console.WriteLine(" ");
            Console.WriteLine("The assignment per course are:");
            Console.WriteLine(" ");
            foreach (var item in assignmentpercourse)
            {
                item.OutputAssignmentPerCourse();
            }
            Console.WriteLine(" ");
            Console.WriteLine("The assignment per course are:");
            Console.WriteLine(" ");
            foreach (var item in assignmentpercourse)
            {
                item.OutputAssignmentPerCourse();
            }




            List<Student> mathites = new List<Student>();

            foreach (var item in studentspercourse)
            {
                foreach (var mathiti in item.Students)
                {
                    if (!mathites.Contains(mathiti))
                    {
                        mathites.Add(mathiti);
                    }

                }
            }
            Console.WriteLine("Student who belong to more than one course: ");
            foreach (var item in mathites)
            {
                item.OutputStudent();
            }

            Console.WriteLine(" ");


            //Λιστα με τους μαθητες που πρεπει να παραδωσουν εργασια
            Console.WriteLine("Students who need to submit one or more assignments: ");
            Console.Write("Enter a date: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());


            CultureInfo gr = new CultureInfo("gr-Gr");
            int week = gr.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);




            List<Student> St1 = new List<Student>();

            foreach (var item in assignmentperstudent)
            {
                foreach (var n in item.AssignmentsPerCourse)
                {
                    foreach (var j in n.Assignments)
                    {
                        CultureInfo gr1 = new CultureInfo("gr-Gr");
                        int weekSubmision = gr1.Calendar.GetWeekOfYear(j.SubDateTime, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
                        if (week == weekSubmision)
                        {
                            St1.Add(item.Student);

                        }

                    }
                }
            }

            List<Student> Smathites = new List<Student>();

            foreach (var item in St1)
            {


                if (!Smathites.Contains(item))
                {
                    Smathites.Add(item);
                }

            }

            foreach (var item in Smathites)
            {
                item.OutputStudent();
            }


        }
    }
}
