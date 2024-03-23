/*
using System;
using System.Collections.Generic;

namespace csday4
{
    public class Student
    {
        int Id { get; set; }//private
        public string Name { get; set; }
        public string Address { get; set; }

        public Student(int id)
        {
            this.Id = id;
        }

    }

    public class StudentOperations
    {
        List<Student> students;

        public void Add(Student st)
        {
            students.Add(st);
        }

        public void DisplayDetails(Student st)
        {
            Console.WriteLine($" Name:{st.Name}, Address:{st.Address}");
        }

        public List<Student> GetAll()
        {
            return students;
        }

    }

    public class Program
    {
        public static void Main()
        {
            Student st = new Student(2);
            st.Name = "Mur";
            st.Address = "Lon";


 Student st1 = new Student(21);
            st1.Name = "Mur1";
            st1.Address = "Lon1";

            StudentOperations stOps = new StudentOperations();
            stOps.DisplayDetails(st);
            stOps.DisplayDetails(st1);
        }
    }
}
*/