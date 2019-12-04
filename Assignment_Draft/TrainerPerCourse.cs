using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Draft
{
    class TrainerPerCourse
    {
        public List<Trainer> Trainers { get; set; }
        public Course Course { get; set; }
        public TrainerPerCourse()
        {
            Course = new Course();
            Trainers = new List<Trainer>();
        }

        public TrainerPerCourse(Course course)
        {
            Course = course;
            Trainers = new List<Trainer>();

        }

        public void OutputTrainerPerCourse()
        {
            Course.OutputCourse();
            Console.WriteLine("Trainers in the course: ");
            foreach (var item in Trainers)
            {
                item.OutputTrainer();
            }
        }

        public void InputTrainerPerCourse()
        {
            Console.WriteLine("Enter a Course: ");
            Course.InputCourse();
            Console.WriteLine("How many trainers has the course?");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Trainers: ");
            for (int i = 0; i < j; i++)
            {
                Trainer t = new Trainer();
                t.InputTrainer();
                Trainers.Add(t);
            }




        }
    }
}
