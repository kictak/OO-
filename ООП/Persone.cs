using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    class Persone
    {
        public string name;
        public string surname;
        public Gender gender;
        private System.DateTime date_of_birth;

        public Persone()
        {
            name = "Степан";
            surname = "Поляков";
        }

        public Persone(string n, string s, DateTime date)
        {
            name = n;
            surname = s;
            date_of_birth = date;
        }
       
    }
}
