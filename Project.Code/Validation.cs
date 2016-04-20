using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public static class Validation
    {
        public static float tryGpa;
        public static float validGpa;

        public static int TestOperation(string operation)
        {
            operation = operation.ToLower();
            if (operation == Operations.en)
                return 1;
            else if (operation == Operations.di)
                return 2;
            //else if (operation == Operations.re) //used for student removal
            //    return 3;
            else
                return 0;
        }
        public static bool TestName(string name)
        {
            if (name.Length < 2)
            {
                Console.Write("The name has to be at least 2 characters long.\n");
                return false;
            }
            else
                return true;
        }
        public static bool TestGPA(string gpa)
        {
            try
            {
                tryGpa = float.Parse(gpa, System.Globalization.CultureInfo.InvariantCulture);
                if (tryGpa >= 0 && tryGpa <= 4)
                    return true;
                else
                    return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        //public static bool testIDFormat(string idString) //used for ID validation in student removal
        //{
        //    try
        //    {
        //        int b = Int32.Parse(idString);
        //        return true;
        //    }
        //    catch (FormatException)
        //    {
        //        return false;
        //    }
        //}
        public static bool TestDisplay()
        {
            if (StudentContainer.students.Count < 1)
                return false;
            else
                return true;
        }
    }
}
