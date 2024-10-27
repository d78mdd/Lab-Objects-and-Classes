using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            for (; ; )
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ');

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.City = city;

                students.Add(student);

            }

            string cityName = Console.ReadLine();

            for (int i = 0; i < students.Count(); i++)
            {
                Student s = students.ElementAt(i);

                if (s.City == cityName)
                {
                    Console.WriteLine(s.FirstName + " " + s.LastName + " is " + s.Age + " years old.");
                }

            }

        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }


    }
}
