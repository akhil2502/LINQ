using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQProject
{
    public class LinqToEntities
    {
        public static void Entities()
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "Raj", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Ram", Age = 20 },
            new Student() { StudentID = 3, StudentName = "Ravi", Age = 21 },
            new Student() { StudentID = 4, StudentName = "john", Age = 25 },
            new Student() { StudentID = 5, StudentName = "Steave", Age = 27 },
            new Student() { StudentID = 6, StudentName = "Robert", Age = 30 },
            new Student() { StudentID = 7, StudentName = "Roy", Age = 17 },
            };
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 2).ToArray();
            foreach (Student student in teenAgerStudents)
            {
                Console.WriteLine("Id:-" + student.StudentID + " " + "Name:-" + student.StudentName + " " + "Age:-" + student.Age + "\n");
            }
            Student Ram = studentArray.Where(s => s.StudentName == "Ram").FirstOrDefault();
            Console.WriteLine("Id:-" + Ram.StudentID + " " + "Name:-" + Ram.StudentName + " " + "Id:-" + Ram.Age + "\n");
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine("Id:-" + student5.StudentID + " " + "Name:-" + student5.StudentName + " " + "Id:-" + student5.Age + "\n");
        }
    }
}