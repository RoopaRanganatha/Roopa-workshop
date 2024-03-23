
using System;
using System.Collections.Generic;
using csday4;

namespace csday4
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
    
   /* public Student (int id)
    {
        this.Id=id;
    }*/
    }

public class StudentOperations
{

    List<Student> students = new List<Student>();

    public void Add(int id, string name, string address)
    {
        Student st = new Student();
        st.Id=id;
        st.Name=name;
        st.Address=address;
        students.Add(st);
    }

     public void GetById(int id)
        {
            for (int i = 0; i < students.Count ; i++)
            {
                if(id==students[i].Id)
                {
                Console.WriteLine($"Id : {students[i].Id}, Name : {students[i].Name},Address:{students[i].Address}");
                break;
                }
            }       
        }

        public void GetAll()
        {
             for (int i = 0; i < students.Count ; i++)
            {               
                 Console.WriteLine($"Id : {students[i].Id}, Name : {students[i].Name},Address:{students[i].Address}");
            }
        }
}

    public class Program
    {
        public static void Main()
        {
           /* Student st = new Student(2);
            st.Name="Roo";
            st.Address="sira";

            Student st1 = new Student(3);
            st1.Name="Seen";
            st1.Address="blr";*/

            StudentOperations studentOperations= new StudentOperations();
           // studentOperations.DisplayDetails(st);
           // studentOperations.DisplayDetails(st1);

            studentOperations.Add(1, "Roo", "Sira");
            studentOperations.Add(2, "Praveen","handikunte");
            studentOperations.GetAll();        
        }
    }
}
/*using System;
using System.Collections.Generic;
using csday4;


namespace csday4
{
    public class Student
    {
        int Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
    
    public Student (int id)
    {
        this.Id=id;
    }
    }

public class StudentOperations{

    List<Student> students = new List<Student>();

    public void Add(Student st)
    {
        students.Add(st);
    }

     public void DisplayDetails(Student st)
        {
            Console.WriteLine($"Name : {st.Name},Address:{st.Address}");
        }

        public List<Student> GetAll()
        {
            return students;
        }
}

    public class Program{
        public static void Main()
        {
            Student st = new Student(2);
            st.Name="Roo";
            st.Address="sira";

            Student st1 = new Student(3);
            st1.Name="Seen";
            st1.Address="blr";

            StudentOperations studentOperations= new StudentOperations();
            studentOperations.DisplayDetails(st);
            studentOperations.DisplayDetails(st1);

            studentOperations.Add(st);
            studentOperations.GetAll();
        
        }
    }
}*/