using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Code;

namespace Project.App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            Console.Write("You can enlist students with the 'Enlist' command or display the students you enlisted so far with the 'display' command.\n");
            while (x)
            {
                Console.Write("Enter your command: ");
                string operation = Console.ReadLine();

                switch (Validation.TestOperation(operation))
                {
                    case 0:
                        Console.Write("You did not enter an applicable command, try again.\n");
                        break;
                    case 1:
                        Student newStudent = new Student();     //temporary storage for new students
                        string testGpa;                         //before moving to StudentContainer?
                        while (true)
                        {
                            Console.Write("First name: ");
                            string testName = Console.ReadLine();
                            if (Validation.TestName(testName))
                            {
                                newStudent.FirstName = testName;
                                break;
                            }
                            else
                                Console.Write("The name has to be at least 2 characters long.\n");
                        }

                        while (true)
                        {
                            Console.Write("Last name: ");
                            string testName = Console.ReadLine();
                            if (Validation.TestName(testName))
                            {
                                newStudent.LastName = testName;
                                break;
                            }
                            else
                                Console.Write("The name has to be at least 2 characters long.\n");
                        }
                        while(true)
                        {
                            Console.Write("GPA: ");
                            testGpa = Console.ReadLine();
                            if (Validation.TestGpa(testGpa))
                            {
                                newStudent.Gpa = float.Parse(testGpa, System.Globalization.CultureInfo.InvariantCulture);
                                break;
                            }
                            else
                            {
                                Console.Write("Please enter a number.\n");
                            }
                        }

                        Console.Write("Student " + newStudent.FirstName + ' ' + newStudent.LastName + " enlisted with ID: " + newStudent.Id + "\n");

                        StudentContainer.AddStudent(newStudent);
                        break;
                    case 2:
                        int i = 1;
                        if (Validation.TestDisplay())
                        {
                            StudentContainer.SortStudents();
                            foreach(Student student in StudentContainer.Students)
                            {
                                Console.Write(i + ". " + student.LastName + ", " + student.FirstName + " - " + student.Gpa + "\n");
                            }
                            x = false;
                        }
                        else
                        {
                            Console.Write("There are no students to display, enlist some using the 'enlist' command.\n");
                        }
                        break;
                }
            }
            Console.Write("Hit the Esc key to exit.");
            do { }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}