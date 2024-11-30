using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    class Student : Persone
    {

        public void Display()
        {
            Console.Write(Name + " " + surname + " учится в " + university);
        }
    }

}
