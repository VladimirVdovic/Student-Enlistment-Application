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
                bool gpaEntry = true;

                switch (Validation.TestOperation(operation))
                {
                    case 0:
                        Console.Write("You did not enter an applicable command, try again.\n");
                        break;
                    case 1:
                        Student newStudent = new Student();     //temporary storage for new students
                        string testGpa;                         //before moving to StudentContainer?
                        Console.Write("First name: ");
                        while (true)
                        {
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
                        while (gpaEntry)
                        {
                            Console.Write("GPA: ");
                            testGpa = Console.ReadLine();
                            switch (Validation.TestGpa(testGpa))
                            {
                                case 0:
                                    gpaEntry = false;
                                    newStudent.Gpa = float.Parse(testGpa, System.Globalization.CultureInfo.InvariantCulture);
                                    break;
                                case 1:
                                    Console.Write("Not a valid number. GPA's range from 0 to 4.\n");
                                    break;
                                case 2:
                                    Console.Write("Please only enter a number.\n");
                                    break;
                            }
                        }

                        Console.Write("Student " + newStudent.FirstName + ' ' + newStudent.LastName + " enlisted with ID: " + newStudent.Id + "\n");

                        if(Validation.TestStudent(newStudent))
                        {
                            StudentContainer.AddStudent(newStudent);
                        }
                        else
                        {
                            Console.Write("An error occured, no values for student information were registered.");
                        }
                        break;

                    case 2:
                        int i = 1;
                        if (Validation.TestDisplay())
                        {
                            StudentContainer.SortStudents();
                            foreach(Student student in StudentContainer.Students)
                            {
                                Console.Write(i + ". " + student.LastName + ", " + student.FirstName + " - " + student.Gpa + "\n");
                                i++;
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