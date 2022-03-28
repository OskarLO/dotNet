using Exercise6v2.DataAccess.Model;
using System;

namespace Exercise6v2.DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {

            AddToDatabase();

        }

        private static void AddToDatabase()
        {
            Student student1 = new Student(1, "Oskar", "Ottesen");
            Student student2 = new Student(1, "Sara", "Nordmann");
            Student student3 = new Student(1, "Kenneth", "Nordmann");
            Student student4 = new Student(1, "Harald", "Nordmann");
            Student student5 = new Student(1, "Magnus", "Nordmann");

            Subject dotNet = new Subject(1, ".net programing");
            Subject kalkulus = new Subject(2, "Kalkulus");
            Subject prog1 = new Subject(3, "Programing 1");
            Subject dataSec = new Subject(4, "Data Secutiry");

            dotNet.AddStudent(student1);
            dotNet.AddStudent(student2);
            dotNet.AddStudent(student3);

            /*using (var db = new Context())
            {
                db.Students.Add(student1);
            };*/
            
        }
    }
}
