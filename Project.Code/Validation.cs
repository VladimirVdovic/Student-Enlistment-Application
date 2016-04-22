using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Validation
    {

        public static bool TestGpa(string gpa)
        {
            float tryGpa;
            try
            {
                tryGpa = float.Parse(gpa, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }

        public static bool TestDisplay()
        {
            if (StudentContainer.Students.Count > 0)
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
    }
}
