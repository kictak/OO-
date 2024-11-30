using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    class Student : Persone
    {
        protected string Name;
        protected string surname;
        protected System.DateTime date_of_birth;
        protected string university;
        public Student(string name, string surname, DateTime date_of_birth, string university)
        {
            this.university = university;
            this.Name = name;
            this.surname = surname;
            this.date_of_birth = date_of_birth;
        }

        public Student()
        {
            Name = "Степан";
            surname = "Поляков";
            date_of_birth = new DateTime(2002, 02, 20);
            university = "sibypk";
        }
        public void Display()
        {
            Console.Write(Name + " " + surname + " учится в " + university + " " + date_of_birth);
        }
    }

}
