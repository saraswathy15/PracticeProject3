using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject3
{

    internal class Data
    {
        private static Data _instance;
        private List<Student> stud;
        private List<Teacher> teach;
        private List<Subject> sub;

        private Data()
        {
            stud = new List<Student>();
            teach = new List<Teacher>();
            sub = new List<Subject>();
        }

        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }

        public void AddStudent(Student student)
        {
            stud.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teach.Add(teacher);
        }

        public void AddSubject(Subject subject)
        {
            sub.Add(subject);
        }

        public List<Student> GetStudentsByClassAndSection(string classAndSection)
        {
            return stud.Where(s => s.ClassAndSection == classAndSection).ToList();
        }

        public List<Subject> GetSubjectsTaughtByTeacher(string teacherName)
        {
            return sub.Where(s => s.Teacher != null && s.Teacher.Name == teacherName).ToList();
        }
    }

}
