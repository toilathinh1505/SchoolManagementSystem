using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    internal class Student : Person
    {
        public Student()
        {
            students = new List<Student>();
        }
        private List<Student> students;

        public override void Input()
        {
            
            do
            {
                base.Input();
                Console.Write("\n =======================================");
                Console.Write("\n - Input Student Id : ");
                Id = Console.ReadLine();
                
            }
            while (!StudentManagement.CheckStudentId(id));
            base.Input();
            Console.Write("\n - Input Student Full Name : ");
            FullName = Console.ReadLine();
            do
            {
                base.Input();
                Console.Write("\n - Input Student Email : ");
                Email = Console.ReadLine();
            }
            while (!StudentManagement.CheckStudentEmail(email));
            base.Input();
            Console.Write("\n - Input Student Address : ");
            Address = Console.ReadLine();
            Console.Write("\n - Input Student Phone Number :");
            Phone = Console.ReadLine();
            Console.Write("\n - Input Student Grade : ");
            Grade = Int32.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("\n ============================================\n");
            Console.WriteLine("\n - Student's Id :" + Id);
            Console.WriteLine("\n - Student's FullName : " + FullName);
            Console.WriteLine("\n - Student's Email : " + Email);
            Console.WriteLine("\n - Student's Address : " + Address);
            Console.WriteLine("\n - Student's Phone Number :" + Phone);
            Console.WriteLine("\n - Student's Grade : " + Grade);
            Console.WriteLine("\n ============================================\n");
        }
    }
}