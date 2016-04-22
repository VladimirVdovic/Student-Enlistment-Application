using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public abstract class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        
        public Person()
        {
            id = StudentIdGenerator.Instance.GenerateId();
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
    }
}
