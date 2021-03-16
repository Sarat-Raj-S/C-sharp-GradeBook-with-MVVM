using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
         {
            while(true)
            {   Console.WriteLine("ENTER STUDENT NAME, \n if no more sudents, enter 'null' : ");
                string student_name = Console.ReadLine();
                string student_name_value = student_name.ToLower();
                if (student_name_value == "null") break;
                Caliculation grade = new Caliculation(student_name); 
                grade.Addgrade();
                grade.showstatistics();
            }

        }
    }
}

  