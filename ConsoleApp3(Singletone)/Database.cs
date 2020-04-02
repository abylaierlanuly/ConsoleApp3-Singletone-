using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_Singletone_
{
   public  class Database
    {
        private static Database _dbInstance;
        private Database()
        {

        }
        public List<Teacher> Teachers = new List<Teacher>();
        public List<Subject> Subjects = new List<Subject>();
        public List<Student> Students = new List<Student>();
        public static Database GetInstance()
        {
            if (_dbInstance == null)
                _dbInstance = new Database();
            return _dbInstance;
        }
        public void AddStudent(Student s)
        {
             Students.Add(s);
        }
        public void AddTeacher(Teacher t)
        {
            Teachers.Add(t); 
        }
        public void AddStudentSubject(Subject sub, Student stud)
        {
            bool check = true;
            foreach (var item in sub.MyStudents)
            {
                if (stud.Id==item.Id)
                {
                    check = false;
                }
            }
            if (check)
            {
                sub.MyStudents.Add(stud);
            }
        }
        public string Subject(Subject sub)
        {
            string result = " Discipline:" + sub.Name +  "         Teacher:" + sub.TeacherName + "     Students Count:" + sub.MyStudents.Count;
            return result;
        }
        }
    }
