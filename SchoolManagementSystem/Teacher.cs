using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Teacher : Person
    {
       public Teacher() 
        {
            teachers = new List<Teacher>();
        }
        private List<Teacher> teachers;
        public float Salary { get; set; }
        public override void Input()
        {
            do
            {
                base.Input();
                Console.Write("\n =======================================");
                Console.Write("\n - Input Teacher Id : ");
                Id = Console.ReadLine();
            }
            while (!TeacherManagement.CheckTeacherId(id));
            base.Input();
            Console.Write("\n - Input Teacher Full Name : ");
            FullName = Console.ReadLine();
            do
            {
                base.Input();
                Console.Write("\n - Input Teacher Email : ");
                Email = Console.ReadLine();
            }
            while(!TeacherManagement.CheckTeacherEmail(email));
            base.Input();
            Console.Write("\n - Input Teacher Address : ");
            Address = Console.ReadLine();
            Console.Write("\n - Input Teacher Phone Number :");
            Phone = Console.ReadLine();
            Console.Write("\n - Input Teacher Salary : ");
            Salary = Int32.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("\n ============================================\n");
            Console.WriteLine("\n - Teacher's Id :" + Id);
            Console.WriteLine("\n - Teacher's FullName : " + FullName);
            Console.WriteLine("\n - Teacher's Email : " + Email);
            Console.WriteLine("\n - Teacher's Address : " + Address);
            Console.WriteLine("\n - Teacher's Phone Number :" + Phone);
            Console.WriteLine("\n - Teacher's Salary : " + Salary);
            Console.WriteLine("\n ============================================\n");
        }

    }
}
