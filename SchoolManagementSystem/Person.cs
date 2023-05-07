using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Person
    {
        protected string id;
        protected string fullname;
        protected string email;
        protected string address;
        protected string phone;
        protected float grade;

        public Person() { }
        public Person(string id, string fullname, string email, string address, string phone, float grade)
        {
            this.id = id;
            this.fullname = fullname;
            this.email = email;
            this.address = address;
            this.phone = phone;
            this.grade = grade;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value;}
        }
        public string Address
        {
            get { return address; }
            set { address = value;}
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public float Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public override string ToString()
        {
            return "\n - Id : " + Id + "\n - FullName : " + FullName + "\n - Email : " + Email + "\n - Address : " + Address + "\n - Phone : " + Phone + "\n - Grade :" + Grade;
        }
        public virtual void Input()
        {      
        }
        public virtual void Output()
        {
        }
    }

}
