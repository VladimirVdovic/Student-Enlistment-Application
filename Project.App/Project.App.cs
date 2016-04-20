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
                        Student temp = new Student();
                        break;
                    case 2:
                        if (Validation.TestDisplay())
                        {
                            StudentContainer.students.Sort();
                            for (int i = 0; i < StudentContainer.students.Count; i++)
                            {
                                Console.Write((i + 1) + ". " + StudentContainer.students[i] + "\n");
                            }
                            x = false;
                        }
                        else
                        {
                            Console.Write("There are no students to display, enlist some using the 'enlist' command.\n");
                        }
                        break;
                        //case 3: //student removal case, not needed in level 1
                        //    StudentContainer.removeStudent();
                        //    break;
                }
            }
            Console.Write("Hit the Esc key to exit.");
            do { }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}