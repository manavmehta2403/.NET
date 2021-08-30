using System;
using System.Collections;
using System.Collections.Generic;

namespace IMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            student.Add(new Student() {Age = 18, Name = "Trix" });
            student.Add(new Student() { Age = 18, Name = "Triex" });
            student.Add(new Student() { Age = 19, Name = "Zrtie" });
            student.Add(new Student() { Age = 16, Name = "Yaiq" });
            student.Add(new Student() { Age = 20, Name = "Xrit" });


            IEnumerator enumerator = student.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Student s = (Student)enumerator.Current;
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("");

            student.Sort();

            foreach (var s in student)
            {
                Console.WriteLine(s.ToString());
            }

            StudentComparer studentComparer = new StudentComparer();
            student.Sort((IComparer<Student>)studentComparer);

            Console.WriteLine("");
            foreach (var s in student)
            {
                Console.WriteLine(s.ToString());
            }

        }
    }

    class Student : IComparable
    {
        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }

        public int CompareTo(object obj)
        {
            Student other = (Student)obj;

            if (this.Age > other.Age)
            {
                return 1;
            }
            else if (this.Age < other.Age)
            {
                return -1;
            }
            else if (this.Age == other.Age)
            {
                return this.Name.CompareTo(other.Name);
            }
            else
            {
                return 0;
            }
        }
    }

    class StudentComparer : IComparer<Student>
    {
        
        public int Compare(Student x, Student y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }
            else if (x.Age < y.Age)
            {
                return -1;
            }
            else if (x.Age == y.Age)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return 0;
            }
        }
    }
}
