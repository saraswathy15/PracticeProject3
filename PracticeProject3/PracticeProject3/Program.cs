using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________");
            Console.WriteLine("Enter student information:");
            Console.WriteLine("_______________________________");
            Student student1 = GetStudentFromUserInput();
            Data.Instance.AddStudent(student1);

            Console.WriteLine("_______________________________");
            Console.WriteLine("\nEnter teacher information:");
            Console.WriteLine("_______________________________");
            Teacher teacher1 = GetTeacherFromUserInput();
            Data.Instance.AddTeacher(teacher1);

            Console.WriteLine("_______________________________");
            Console.WriteLine("\nEnter subject information:");
            Console.WriteLine("_______________________________");
            Subject subject1 = GetSubjectFromUserInput();
            Data.Instance.AddSubject(subject1);

            Console.WriteLine("______________________________________________________");
            Console.WriteLine("\nEnter the class and section to display students:");
            Console.WriteLine("______________________________________________________");
            string classAndSectionInput = Console.ReadLine();
            List<Student> studentsInClass = Data.Instance.GetStudentsByClassAndSection(classAndSectionInput);
            Console.WriteLine("\nStudents in class " + classAndSectionInput + ":");
            foreach (var student in studentsInClass)
            {
                Console.WriteLine($"{student.Name}");
            }

            Console.WriteLine("\nEnter the teacher name to display subjects:");
            string teacherNameInput = Console.ReadLine();
            List<Subject> subjectsTaughtByTeacher = Data.Instance.GetSubjectsTaughtByTeacher(teacherNameInput);
            Console.WriteLine("\nSubjects taught by " + teacherNameInput + ":");
            foreach (var subject in subjectsTaughtByTeacher)
            {
                Console.WriteLine($"{subject.Name} - {subject.SubjectCode}");
            }
            Console.ReadKey();
        }

        static Student GetStudentFromUserInput()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Class and Section: ");
            string classAndSection = Console.ReadLine();

            return new Student { Name = name, ClassAndSection = classAndSection };
        }

        static Teacher GetTeacherFromUserInput()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Class and Section: ");
            string classAndSection = Console.ReadLine();

            return new Teacher { Name = name, ClassAndSection = classAndSection };
        }

        static Subject GetSubjectFromUserInput()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Subject Code: ");
            string subjectCode = Console.ReadLine();

            Console.Write("Teacher Name: ");
            string teacherName = Console.ReadLine();

            return new Subject { Name = name, SubjectCode = subjectCode, Teacher = new Teacher { Name = teacherName } };
        }
    }

}
