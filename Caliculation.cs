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
        private static double highest_grade_student;
        private static double lowest_grade_class;
        private static double lowest_grade_student;
        private int number_of_subj;


        public Caliculation()
        {
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
            Console.WriteLine("GET THE GRADES FROM USER, CONTINUESLY SHOWING THE PREVIOUS INPUT AND AS SOON AS USER STOPS THE ENTRY, GET ASK FOR A TERMINATOR,for every subject");
            while(true)
            {
                number_of_subj = 1;
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
            average_grade = result/number_of_
            Console.WriteLine($

        }
        public void high_low_grade_check()
        {

            foreach (double value in grades)
            {

                if (value > Caliculation.highest_grade_class)
                {
                    Caliculation.highest_grade_class = value;
                }
                Console.WriteLine($"The highest grade achieved till now is  : {Caliculation.highest_grade_class} in subject:");
            }
            foreach (double value in grades)
            {

                if (value > Caliculation.highest_grade_student)
                {
                    Caliculation.highest_grade_student = value;
                }
                Console.WriteLine($"The highest among all the grades scored by student is : {Caliculation.highest_grade_student} in subject:");
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

                if (value > Caliculation.lowest_grade_student)
                {
                    Caliculation.lowest_grade_student = value;
                }
                Console.WriteLine($"The lowest among all the grades scored by student is : {Caliculation.lowest_grade_student} in subject:");
            }
        }
    }
}
