using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SchoolManagementSystem
{
    internal class StudentManagement 
    {
        public StudentManagement() 
        {
            students = new List<Student>();
        }

        private List<Student> students;
        public void AddNewStudent(Student s)

        {
            students.Add(s);
        }
       
        public void ViewStudents()
        {
            students.ForEach(s => s.Output());
        }
        public void SearchStudentId(string id)
        {
            students.Where(s => s.Id.ToLower().Equals(id.ToLower())).First().Output();
        }
        public void DeleteStudent()
        {
            Console.WriteLine(" Input Id : ");
            string id;
            id = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students.RemoveAt(i);
                }
            }
        }
        public void UpdateStudent()
        {
           
            Console.WriteLine(" Input Id : ");
            string id;
            id = Console.ReadLine();
            Student s = students.Find(s => s.Id == id);
            for (int i = 0; i < students.Count; i++)
            {
                if (id == students[i].Id)
                {
                    Console.Write(" - Input Student FullName : ");
                    students[i].FullName = Console.ReadLine();
                    Console.Write(" - Input Student Email : ");
                    students[i].Email = Console.ReadLine();
                    Console.Write(" - Input Student Address : ");
                    students[i].Address = Console.ReadLine();
                    Console.Write(" - Input Student Phone Number :");
                    students[i].Phone = Console.ReadLine();
                    Console.Write(" - Input Student Grade : ");
                    students[i].Grade = Int32.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Student Founded.");
                }
            }
        }
        public void ScholarShip()
        {
            Console.WriteLine("Students have Scholarship : ");
            foreach (Student s in students)
            {
                if (s.Grade > 8)
                {
                    Console.WriteLine(s.FullName);
                }
            }
        }
        public static bool CheckStudentId(string id)
        {
            if ((id.StartsWith("GCS")) || (id.StartsWith("GBS")) && (id.Length == 9) && (char.IsNumber(id, 3)) == true && (char.IsNumber(id, 3)) == true && (char.IsNumber(id, 4)) == true && (char.IsNumber(id, 5)) == true && (char.IsNumber(id, 6)) == true)
            {
                return true;
            }
            else
                Console.WriteLine("\n ==== Incorrected Id , Please type corecct form ( GCSxxxxx or GBSxxxxx) ===== ");
                return false ;
                    
            
        }
        public static bool CheckStudentEmail(string email)
        {
            string a = "@";
            string c = " ";
            
            if (email.Contains(a))
            {
                return true;
            }
                Console.Write("\n ===============Incorecct Email form , please type Email with @ ==================");
            return false; 
        }
       
    }
}
