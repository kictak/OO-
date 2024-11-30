using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ООП
{
    class Persone
    {
        protected string Name;
        protected string surname;
        protected Gender gender;
        protected System.DateTime date_of_birth;
        public Persone(string name, string surname, DateTime date_of_birth)
        {
            this.Name = name;
            this.surname = surname;
            this.date_of_birth = date_of_birth;
        }
        public Persone()
        {
            Name = "Степан";
            surname = "Поляков";
            date_of_birth = new DateTime(2002,02,20);
        }
        public void SetName(string value)
        {
            Name = value;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetSurname(string value)
        {
            surname = value;
        }
        public string GetSurname()
        {
            return surname;
        }
        public void SetDatetime(DateTime value)
        {
            date_of_birth = value;
        }
        public DateTime Getdate_of_birth()
        {
            return date_of_birth;
        }
        public string ToFullString()
        {
            return GetName() + "  " + GetSurname() + "  " + Getdate_of_birth();
        }  

        public void Display()
        {
            Console.Write(Name + " " + surname + " " +  date_of_birth);
        }
       
    }

}

//public void  SetName(string value)
//{
//    if(Regex.IsMatch (value, "^[А-ЯЁ][а-яё]{2,}$"))
//    {
//        name = value;
//    }
//    else
//    {
//        throw new Exception("Имя не соответствует шаблону");
//    }
//}