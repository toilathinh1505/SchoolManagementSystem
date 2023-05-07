using System;
using SchoolManagementSystem;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace SchoolManagementSystem
{
    internal class SchoolManagement 
    {
        public static List<Student> ListStudents;
        public static List<Teacher> ListTeachers;
        public void MainMenu()
        {
            string userchoose = String.Empty;
            SchoolManagement school = new SchoolManagement();
            Console.WriteLine("============ HIGHSCHOOL MANAGEMENT SYSTEM ================");
            Console.WriteLine("1. STUDENTS MANAGEMENT ");
            Console.WriteLine("2. TEACHERS MANAGEMENT ");
            Console.WriteLine("3. Exit");
            Console.WriteLine("===========================================================");
            Console.Write("Please Choose : ");
            userchoose = Console.ReadLine();
            switch(userchoose)
            {
                case "1":
                    school.MenuStudent();
                    break;
                case "2":
                    school.MenuTeacher();
                    break;
                case "3":
                    break;
            }
            while (userchoose != "3") ;
        }
        public void MenuStudent()
        {
            string userchoose = String.Empty;
            StudentManagement manage = new StudentManagement();
            do
            {
                // Sub menu Student Managemen
                Console.WriteLine("=============STUDENT MANAGEMENT MENU===============");
                Console.WriteLine("===================================================");
                Console.WriteLine("1. Add new Student");
                Console.WriteLine("2. View all Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Update Student");
                Console.WriteLine("6. Student have Scholarship");
                Console.WriteLine("7. Back to Main Menu");
                Console.WriteLine("=====================================================");
                Console.Write("Please Choose : ");
                userchoose = Console.ReadLine();
                switch (userchoose)
                {
                    case "1":
                        Student student = new Student();
                        student.Input();
                        manage.AddNewStudent(student);
                        break;
                    case "2":
                        manage.ViewStudents();
                        break;
                    case "3":
                        Console.WriteLine("Input Student ID : ");
                        string searchstudentid = Console.ReadLine();
                        manage.SearchStudentId(searchstudentid);
                        break;
                    case "4":
                        manage.DeleteStudent();
                        break;
                    case "5":
                        manage.UpdateStudent();
                        break;
                    case "6":
                        manage.ScholarShip();
                        break;
                    case "7":
                        SchoolManagement school = new SchoolManagement();
                        school.MainMenu();
                        break;
                }
            } while (userchoose != "7");
        }
        public void MenuTeacher()
        {
            TeacherManagement manage = new TeacherManagement();
            string userchoose = String.Empty;
            do
            {
                Console.WriteLine("===============TEACHER MANAGEMENT MENU=====================");
                Console.WriteLine("===========================================================");
                Console.WriteLine("1. Add new Teacher");
                Console.WriteLine("2. View all Teachers");
                Console.WriteLine("3. Search Teacher");
                Console.WriteLine("4. Delete Teacher");
                Console.WriteLine("5. Update Teacher");
                Console.WriteLine("6. Back to main menu");
                Console.WriteLine("===========================================================");
                Console.Write("Please Choose : ");
                userchoose = Console.ReadLine();
                switch (userchoose)
                {
                    case "1":
                        Teacher teacher = new Teacher();
                        teacher.Input();
                        manage.AddNewTeacher(teacher);
                        break;
                    case "2":
                        manage.ViewTeacher();
                        break;
                    case "3":
                        Console.WriteLine("Input Student ID : ");
                        string searchteacherid = Console.ReadLine();
                        manage.SearchTeacherId(searchteacherid);
                        break;
                    case "4":
                        manage.DeleteTeacher();
                        break;
                    case "5":
                        manage.UpdateTeacher();
                        break;
                    case "6":
                        SchoolManagement school = new SchoolManagement();
                        school.MainMenu();
                        break;
                }
            } while (userchoose != "6");
        }
        static void Main(string[] args)
        {
            ListStudents = new List<Student>();
            ListTeachers = new List<Teacher>();
            SchoolManagement school = new SchoolManagement();
            school.MainMenu();
            // Wait console for read
            Console.Read();
        }
    }
}
