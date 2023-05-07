using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    internal class TeacherManagement 
    {
        public TeacherManagement() 
        {
            teachers = new List<Teacher>();
        }
        private List<Teacher> teachers;

        public static List<Teacher> ListTeachers = new List<Teacher>();
        public void AddNewTeacher(Teacher t)
        {
            teachers.Add(t);
        }
        public void ViewTeacher()
        {
            teachers.ForEach(t => t.Output());
        }
        public void DeleteTeacher()
        {
            Console.WriteLine(" Input Id : ");
            string id;
            id = Console.ReadLine();
            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachers[i].Id == id)
                {
                    teachers.RemoveAt(i);
                }
            }
        }
        public void UpdateTeacher()
        {
            Console.WriteLine(" Input Teacher Id : ");
            string id;
            id = Console.ReadLine();
            Teacher t = teachers.Find(t => t.Id == id);
            for (int i = 0; i < teachers.Count; i++)
            {
                if (id == teachers[i].Id)
                {
                    Console.Write(" - Input Teacher FullName : ");
                    teachers[i].FullName = Console.ReadLine();
                    Console.Write(" - Input Teacher Email : ");
                    teachers[i].Email = Console.ReadLine();
                    Console.Write(" - Input Teacher Address : ");
                    teachers[i].Address = Console.ReadLine();
                    Console.Write(" - Input Teacher Phone Number :");
                    teachers[i].Phone = Console.ReadLine();
                    Console.Write(" - Input Teacher Salary : ");
                    teachers[i].Salary = Int32.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Teacher Founded.");
                }
            }
        }
        public void SearchTeacherId(string id)
        {
            teachers.Where(t => t.Id.ToLower().Equals(id.ToLower())).First().Output();
        }
        public static bool CheckTeacherId(string id)
        {
            if ((id.StartsWith("GCS")) || (id.StartsWith("GBS")) && (id.Length == 9) && (char.IsNumber(id, 3)) == true && (char.IsNumber(id, 3)) == true && (char.IsNumber(id, 4)) == true && (char.IsNumber(id, 5)) == true && (char.IsNumber(id, 6)) == true)
            {
                return true;
            }
            else
                Console.WriteLine("\n ===Incorrected Id , Please type corecct form ( GCSxxxxx or GBSxxxxx) ===== ");
            return false;
        }
        public static bool CheckTeacherEmail(string email)
        {
            string a = "@";

            if (email.Contains(a))
            {
                return true;
            }
            else
            Console.Write("\n - Incorecct Email form , please type Email with @ ");
            return false;
        }
    }
}

