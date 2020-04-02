using System;
using System.Linq;

namespace ConsoleApp3_Singletone_
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = Database.GetInstance();
            Teacher teacher1 = new Teacher("Alex", 1);
            Teacher teacher2 = new Teacher("Denis", 2);
            db.AddTeacher(teacher1);
            db.AddTeacher(teacher2);
            Subject Cs = new Subject("Computer Since");
            Cs.SetTeacher(teacher2);
            Student student = new Student("Kuchar", 1);
            Student student1 = new Student("Mark", 2);
            db.AddStudent(student);
            db.AddStudent(student1);
            db.AddStudentSubject(Cs, student);
            db.AddStudentSubject(Cs, student1);
            Console.WriteLine(db.Subject(Cs));
            Console.WriteLine("\n");
            var studentss = from table in db.Students
                         select table.Name;
            var teacherss = from table in db.Teachers
                            select table.Name;
            foreach (var item in studentss)
            {
                Console.WriteLine("Students: " + item);
            }
            foreach (var item in teacherss)
            {
                Console.WriteLine("Teachers: " + item);
            }
        }
    } }
