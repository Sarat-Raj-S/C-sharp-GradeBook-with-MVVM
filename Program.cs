using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
         {
            Caliculation grade = new Caliculation();
            grade.Addgrade();
            grade.showstatistics();

        }
    }
}

  