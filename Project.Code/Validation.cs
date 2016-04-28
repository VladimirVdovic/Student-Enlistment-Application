using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Validation
    {

        public static int TestGpa(string gpa)
        {
            float tryGpa;
            try
            {
                tryGpa = float.Parse(gpa, System.Globalization.CultureInfo.InvariantCulture);
                if (tryGpa >= 0 && tryGpa <= 4)
                    return 0;
                else
                    return 1;
                    
            }
            catch (FormatException)
            {
                return 2;
            }
        }

        public static bool TestDisplay()
        {
            if (StudentContainer.Students.Any())
                return true;
            else
                return false;
        }

        public static int TestOperation(string operation)
        {
            operation = operation.ToLower();
            if (operation == Operations.enlist)
                return 1;
            else if (operation == Operations.display)
                return 2;
            else
                return 0;
        }

        public static bool TestName(string name)
        {
            if (name.Length < 2)
            {
                return false;
            }
            else
                return true;
        }

        public static bool TestStudent(Student newStudent)
        {
            if (newStudent == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
