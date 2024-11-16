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
            Magazine magazineObj = new Magazine();
            string magazineOpisanie = magazineObj.ToShortString();
            Console.WriteLine(magazineOpisanie);
        }
        
    }
}
