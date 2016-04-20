using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        public static List<string> students = new List<string>();
        public static List<int> studentIds = new List<int>();
        //public static string removeID; //used for the removeStudent() method

        public static void AddStudent(string surname, string name, float gpa, int id)
        {   //this will store students and IDs, but IDs are not linked to students, so sorting wrecks it. Until sorted, IDs match students
            students.Add(surname + ", " + name + " - " + gpa);
            studentIds.Add(id);
        }
    }
}