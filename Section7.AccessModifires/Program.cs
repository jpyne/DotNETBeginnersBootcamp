﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7.AccessModifires.Public
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.PrintStudent() //Error because it's private
        }
    }

    public class Student
    {
        public string StudentName { get; set; }

        void PrintStudent()
        {

        }
    }
}
