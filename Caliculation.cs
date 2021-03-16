using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    class Caliculation
    {
        private List<double> grades;
        private static double highest_grade_class;
        private double highest_grade_student;
        private static double lowest_grade_class;
        private double lowest_grade_student;
        private int number_of_subj = 1;
        public string name_of_student;


        public Caliculation(string name_of_student)
        {
            name_of_student = this.name_of_student;
            grades = new List<double>();
        }
        public void showstatistics()
        {
            Average_grade();
            high_low_grade_check();
        }
        public void Addgrade()
        {
            //string read_value = "a";
            Console.WriteLine("enter the grades scored, after completion enter 'ok' ");
            while(true)
            {
                Console.WriteLine($"Marks in Subject {number_of_subj}:");
                string read_value = Console.ReadLine();
                if (read_value != "ok") grades.Add(Convert.ToDouble(read_value));
                else if (read_value == "ok") break;
                number_of_subj++;
            }
        }
        private void Average_grade()
        {
            double result = 0.0;
            double average_grade = 0.0;
            foreach (double value in grades)
            {
                result += value;
            }
            average_grade = result/number_of_subj;
            Console.WriteLine($"Average grade scored by the student : {name_of_student} is :{result}");

        }
        public void high_low_grade_check()
        {

            foreach (double value in grades)
            {

                if (value > Caliculation.highest_grade_class)
                {
                    Caliculation.highest_grade_class = value;
                }
                Console.WriteLine($"The highest grade in class achieved till now is  : {Caliculation.highest_grade_class} in subject:");
            }
            foreach (double value in grades)
            {

                if (value > highest_grade_student)
                {
                    highest_grade_student = value;
                }
                Console.WriteLine($"The highest among all the grades scored by student is : {highest_grade_student} in subject:");
            }
            foreach (double value in grades)
            {

                if (value > Caliculation.lowest_grade_class)
                {
                    Caliculation.lowest_grade_class = value;
                }
                Console.WriteLine($"The lowest among all the grades scored by student is : {Caliculation.lowest_grade_class} in subject:");
            }
            foreach (double value in grades)
            {

                if (value > lowest_grade_student)
                {
                    lowest_grade_student = value;
                }
                Console.WriteLine($"The lowest among all the grades scored by student is : {lowest_grade_student} in subject:");
            }
        }
    }
}
