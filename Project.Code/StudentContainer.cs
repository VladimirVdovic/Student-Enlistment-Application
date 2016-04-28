using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        private static List<Student> students = new List<Student>();

        public static IEnumerable<Student> Students
        {
            get
            {
                return students;
            }
        }

        public static void AddStudent(Student newStudent)
        {
            students.Add(newStudent);
        }

        public static void SortStudents()
        {
            students.Sort((x, y) => string.Compare(x.LastName, y.LastName));
        }
    }
}