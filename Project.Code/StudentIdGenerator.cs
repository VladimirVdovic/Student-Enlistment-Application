﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator instance;
        private static int studentId;
        private StudentIdGenerator()
        {
            studentId = 0;
        }
        public static StudentIdGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentIdGenerator();
                }
                return instance;
            }
        }

        public int GenerateId()
        {
            return studentId++;
        }
    }
}
