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
            Console.WriteLine(persone1.GetName());
            Console.WriteLine(persone1.GetSurname());
            Console.WriteLine(persone1.Getdate_of_birth());
        }
    }
}
