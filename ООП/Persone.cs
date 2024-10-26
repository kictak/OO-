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
        private string name;
        private string surname;
        private Gender gender;
        private System.DateTime date_of_birth;
        public Persone(string n, string s, DateTime date)
        {
            name = n;
            surname = s;
            date_of_birth = date;
        }
        public Persone()
        {
            name = "Степан";
            surname = "Поляков";
        }

       
        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }

        public DateTime Getdate_of_birth()
        {
            return date_of_birth;
        }

        public string ToFullString()
        {
            return GetName() + "  " + GetSurname() + "  " + Getdate_of_birth();
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