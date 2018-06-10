using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classDemo
{
        class Student
    {
        //property
        public int StudentID;
        public string Name;
        public int Grade;

        public Student(int x, string y)
        {
            StudentID = x;
            Name = y;
            Grade = 1;
        }

        //Method
        public string Say()
        {
            return "My name is " + Name + "; I am "+Grade+" year student"; 
        }
        public void Upgrade() {
            Grade++;
        }
        public string Talk(Student s)
        {
            return "I am " + Grade + " year student; " + "How are you~ "  ;
        }
    }
}
