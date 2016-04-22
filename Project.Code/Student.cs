using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Student : Person
    {
        private float gpa;

        public float Gpa
        {
            get
            {
                return gpa;
            }
            set
            {
                gpa = value;
            }
        }
    }
}