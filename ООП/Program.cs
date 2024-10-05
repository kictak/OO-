using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persone persone1 = new Persone();

            //persone1.name = "Степан";
            //persone1.surname = "Поляков";
            //persone1.gender = Gender.Male;

            Console.WriteLine(persone1.name);
            Console.WriteLine(persone1.surname);
            Console.WriteLine(persone1.gender);


            Persone p2 = new Persone("fghfghf", "qwqeqeqe", new DateTime(2020, 09, 09));


            Console.WriteLine(p2.name);
            Console.WriteLine(p2.surname);

            Console.WriteLine(persone1.name);
        }
    }
}
