using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Draft
{
    class AssignmentPerStudent
    {

    
        public Student Student { get; set; }
        public List<AssignmentPerCourse> AssignmentsPerCourse { get; set; }
        public AssignmentPerStudent()
        {

        }
        public AssignmentPerStudent(Student s)
        {
            Student = s;
            AssignmentsPerCourse = new List<AssignmentPerCourse>();
        }

        public void OutputAssignmentsPerStudent()
        {
            Student.OutputStudent();
            foreach (var item in AssignmentsPerCourse)
            {
                item.Course.OutputCourse();
                foreach (var i in item.Assignments)
                {
                    i.OutputAssignment();
                }
            }
        }
       
    }

}
