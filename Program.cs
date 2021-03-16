using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
         {
            for(int i = 1; ;i++)
            {
                Console.WriteLine("enter name of student :");
                string student_name = Console.ReadLine();
                Caliculation grade = new Caliculation(student_name); 
                grade.Addgrade();
                grade.showstatistics();
                Console.WriteLine("if no more sudents, enter 'null'");
                Console.ReadLine();
            }

        }
    }
}

  