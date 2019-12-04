using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Assignment_Draft
{
    public static class SyntheticData
    {
        public static void ReadDataBase()
        {
            Student S1 = new Student("vlassis", "Bakas", new DateTime(1993, 06, 28), 2500);
            Student S2 = new Student("Giorgos", "Nikolaou", new DateTime(1995, 03, 08), 2500);
            Student S3 = new Student("Gianis", "Maratos", new DateTime(1987, 06, 05), 2500);
            Student S4 = new Student("Dimitris", "Papadopoulos", new DateTime(1989, 12, 01), 2500);
            Student S5 = new Student("Takis", "Pappas", new DateTime(1992, 01, 14), 2500);
            Student S6 = new Student("Alex", "Kiriazis", new DateTime(1994, 05, 22), 2500);
            Student S7 = new Student("Katerina", "Statouri", new DateTime(1996, 07, 19), 2500);
            Student S8 = new Student("Eirini", "Katsa", new DateTime(1990, 03, 30), 2500);
            Student S9 = new Student("Haris", "Skoulas", new DateTime(1988, 02, 28), 2500);
            Student S10 = new Student("eleni", "Alexopoulou", new DateTime(1993, 04, 22), 2500);

            List<Student> Students = new List<Student>();
            Students.Add(S1);
            Students.Add(S2);
            Students.Add(S3);
            Students.Add(S4);
            Students.Add(S5);
            Students.Add(S6);
            Students.Add(S7);
            Students.Add(S8);
            Students.Add(S9);
            Students.Add(S10);
            Console.WriteLine("Student: ");
            foreach (var item in Students)
            {
                item.OutputStudent();
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                                           ");
            //Courses and List of Courses
            Course c1 = new Course("CB8", "C#", "Part Time", new DateTime(2019, 05, 13), new DateTime(2019, 11, 13));
            Course c2 = new Course("CB8", "java", "Part Time", new DateTime(2019, 05, 13), new DateTime(2019, 11, 13));

            List<Course> courses = new List<Course>();
            courses.Add(c1);
            courses.Add(c2);
            Console.WriteLine("Courses: ");
            foreach (var item in courses)
            {
                item.OutputCourse();
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                                           ");
            // Σημαντικο μην το διαγραψω ειναι για το input
            //Course c5 = new Course();
            //c5.InputCourse();
            //c5.OutputCourse();

            //Trainers and List of trainers
            Trainer t1 = new Trainer("Xristos", "Petrou", "C#");
            Trainer t2 = new Trainer("Maria", "Fotopoulou", "Java");
            Trainer t3 = new Trainer("Eirini", "Zaxaropolou", "C#");
            Trainer t4 = new Trainer("Ektoras", "Gatsos", "Java");

            List<Trainer> trainers = new List<Trainer>();
            trainers.Add(t1);
            trainers.Add(t2);
            trainers.Add(t3);
            trainers.Add(t4);
            Console.WriteLine("Trainers: ");
            foreach (var item in trainers)
            {
                item.OutputTrainer();
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                                           ");
            //Assignment and List of Assignments
            Assignment a1 = new Assignment("Project 1", "Make a school", new DateTime(2019, 05, 30), 95, 90);
            Assignment a2 = new Assignment("Project 2", "Make a car", new DateTime(2019, 06, 15), 80, 81);
            Assignment a3 = new Assignment("Project 3", "Make a bank", new DateTime(2019, 06, 25), 80, 81);
            Assignment a4 = new Assignment("Project 4", "Make a house", new DateTime(2019, 07, 25), 80, 81);


            List<Assignment> Assignments = new List<Assignment>();
            Assignments.Add(a1);
            Assignments.Add(a2);
            Assignments.Add(a3);
            Assignments.Add(a4);
            Console.WriteLine("Assignments: ");
            foreach (var item in Assignments)
            {
                item.OutputAssignment();
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                                           ");
            //Students per Course
            StudentsPerCourse SC1 = new StudentsPerCourse(c1);
            StudentsPerCourse SC2 = new StudentsPerCourse(c2);

            SC1.Students.Add(S1);
            SC1.Students.Add(S2);
            SC1.Students.Add(S3);
            SC1.Students.Add(S4);
            SC1.Students.Add(S5);
            SC1.Students.Add(S6);



            SC2.Students.Add(S6);
            SC2.Students.Add(S7);
            SC2.Students.Add(S8);
            SC2.Students.Add(S9);
            SC2.Students.Add(S10);
            SC2.Students.Add(S1);
            SC2.Students.Add(S2);



            // SC1.OutputStudentsPerCourse();
            // SC2.OutputStudentsPerCourse();

            List<StudentsPerCourse> StudentsPerCourse = new List<StudentsPerCourse>();
            StudentsPerCourse.Add(SC1);
            StudentsPerCourse.Add(SC2);

            Console.WriteLine("Students per course:");
            foreach (var item in StudentsPerCourse)
            {
                item.OutputStudentsPerCourse();
            }


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                                           ");







            // Trainer per course
            TrainerPerCourse tc1 = new TrainerPerCourse(c1);
            TrainerPerCourse tc2 = new TrainerPerCourse(c2);

            tc1.Trainers.Add(t1);
            tc1.Trainers.Add(t3);

            tc2.Trainers.Add(t2);
            tc2.Trainers.Add(t4);
            List<TrainerPerCourse> trainersPerCourse = new List<TrainerPerCourse>();
            trainersPerCourse.Add(tc1);
            trainersPerCourse.Add(tc2);
            Console.WriteLine("Trainers per course:");
            foreach (var item in trainersPerCourse)
            {
                item.OutputTrainerPerCourse();
            }


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                                           ");
            // Assignment per course
            AssignmentPerCourse ac1 = new AssignmentPerCourse(c1);
            AssignmentPerCourse ac2 = new AssignmentPerCourse(c2);

            ac1.Assignments.Add(a1);
            ac1.Assignments.Add(a2);
            ac1.Assignments.Add(a3);
            ac1.Assignments.Add(a4);


            ac2.Assignments.Add(a1);
            ac2.Assignments.Add(a2);
            ac2.Assignments.Add(a3);
            ac2.Assignments.Add(a4);





            List<AssignmentPerCourse> assignmentsPerCourse = new List<AssignmentPerCourse>();

            assignmentsPerCourse.Add(ac1);
            assignmentsPerCourse.Add(ac2);
            Console.WriteLine("Assignments per course:");
            foreach (var item in assignmentsPerCourse)
            {
                item.OutputAssignmentPerCourse();
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                                           ");

            List<AssignmentPerStudent> assignmentsPerStudents = new List<AssignmentPerStudent>();
            AssignmentPerStudent k = new AssignmentPerStudent(S1);
            
            k.AssignmentsPerCourse.Add(ac1);
            k.AssignmentsPerCourse.Add(ac2);
            //k.OutputAssignmentsPerStudent();
            assignmentsPerStudents.Add(k);
            AssignmentPerStudent k1 = new AssignmentPerStudent(S2);
            k1.AssignmentsPerCourse.Add(ac1);
            k1.AssignmentsPerCourse.Add(ac2);
            // k1.OutputAssignmentsPerStudent();
            assignmentsPerStudents.Add(k1);
            AssignmentPerStudent k2 = new AssignmentPerStudent(S3);
            k2.AssignmentsPerCourse.Add(ac1);
            //k2.OutputAssignmentsPerStudent();
            assignmentsPerStudents.Add(k2);
            AssignmentPerStudent k3 = new AssignmentPerStudent(S5);
            k3.AssignmentsPerCourse.Add(ac1);

            //k3.OutputAssignmentsPerStudent();
            assignmentsPerStudents.Add(k3);
            AssignmentPerStudent k4 = new AssignmentPerStudent(S7);
            k4.AssignmentsPerCourse.Add(ac2);

            //k4.OutputAssignmentsPerStudent();
            assignmentsPerStudents.Add(k4);
            AssignmentPerStudent k5 = new AssignmentPerStudent(S8);
            k5.AssignmentsPerCourse.Add(ac2);

            //k5.OutputAssignmentsPerStudent();
            assignmentsPerStudents.Add(k5);
            AssignmentPerStudent L = new AssignmentPerStudent(S6);
            L.AssignmentsPerCourse.Add(ac1);
            L.AssignmentsPerCourse.Add(ac2);
            //L.OutputAssignmentsPerStudent();
            assignmentsPerStudents.Add(L);
            AssignmentPerStudent M = new AssignmentPerStudent(S4);
            M.AssignmentsPerCourse.Add(ac1);
            //M.OutputAssignmentsPerStudent();
            assignmentsPerStudents.Add(M);
            AssignmentPerStudent k6 = new AssignmentPerStudent(S9);
            k6.AssignmentsPerCourse.Add(ac2);
            assignmentsPerStudents.Add(k6);
            //k6.OutputAssignmentsPerStudent();
            AssignmentPerStudent k7 = new AssignmentPerStudent(S10);

            k7.AssignmentsPerCourse.Add(ac2);
            assignmentsPerStudents.Add(k7);
            //k7.OutputAssignmentsPerStudent();
            Console.WriteLine("Assignments per Student:");
            foreach (var item in assignmentsPerStudents)
            {
                item.OutputAssignmentsPerStudent();
            }


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                                           ");

            //Λιστα με μαθητες που ειναι γραμμενοι σε παραπανω απο ενα μαθημα

            List<Student> St = new List<Student>();
            //List<Student> dipla = new List<Student>();
            foreach (var item in StudentsPerCourse)
            {
                foreach (var i in item.Students)
                {
                    if (!St.Contains(i))
                    {
                        St.Add(i);
                    }
                    //else
                    //    dipla.Add(i);
                }
            }
            Console.WriteLine("Student who belong to more than one course: ");
            foreach (var item in St)
            {
                item.OutputStudent();
            }


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("                                           ");
            //Λιστα με τους μαθητες που πρεπει να παραδωσουν εργασια
            Console.WriteLine("Students who need to submit one or more assignments: ");
            Console.Write("Enter a date: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());


            CultureInfo gr = new CultureInfo("gr-Gr");
            int week = gr.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);




            List<Student> St1 = new List<Student>();

            foreach (var item in assignmentsPerStudents)
            {
                foreach (var i in item.AssignmentsPerCourse)
                {
                    foreach (var j in i.Assignments)
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

            foreach (var i in St1)
            {


                if (!Smathites.Contains(i))
                {
                    Smathites.Add(i);
                }

            }

            foreach (var item in Smathites)
            {
                item.OutputStudent();
            }
        }

    }
}
