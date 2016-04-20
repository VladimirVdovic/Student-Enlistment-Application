using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Student : Person
    {
        public float gpa;
        public string test;

        public Student()
        {
            id = StudentIdGenerator.GenerateId();
            do
            {
                Console.Write("Enter the student's first name: ");
                firstName = Console.ReadLine();
            } while (!Validation.TestName(firstName));

            do
            {
                Console.Write("Enter the student's last name: ");
                lastName = Console.ReadLine();
            } while (!Validation.TestName(lastName));

            do
            {
                Console.Write("Enter the student's GPA: ");
                test = Console.ReadLine();
                if (Validation.TestGPA(test))
                {
                    gpa = float.Parse(test, System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.Write("Please enter only numbers. Also, GPA's range from 0 to 4.\n");
                }
            } while (!Validation.TestGPA(test));
            StudentContainer.AddStudent(lastName, firstName, gpa, id);
            Console.Write("Student " + firstName + " " + lastName + " enlisted with ID - " + id + ".\n");
        }
    }
}
