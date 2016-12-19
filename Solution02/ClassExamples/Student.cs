using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class Student
    {
        public Student(int age)
        {
            Age = age;
            Phone = string.Empty;
            Email = string.Empty;
        }

        public Student(int age, string firstName, string lastName) : this(age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private string firstName = string.Empty;
        private string lastName = string.Empty;
        //private string email;
        //private string phone;
        private int birthYear;

        public bool IsAdult
        {
            get
            {
                return Age > 18;
            }
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email { get; set; }
        public string Phone { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - birthYear;
            }

            set
            {
                birthYear = DateTime.Now.Year - value;
            }
        }
    }

    class ClassRoom
    {
        string name;
        Student[] students;
    }

    class Example
    {
        public Example(int n)
        {
            this.n = n;
        }

        public int N { get; private set; }

        public void ChnageN(int n)
        {
            N = n;
            //this.n = n;
        }

        public static string staticName = "Example";

        public static void ChnageName(string name)
        {
            staticName = name;
            //N = 1;
        }

        public const string className = "Example";
        public readonly int n;
    }
}
