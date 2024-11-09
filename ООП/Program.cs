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

            int[] a = new int[2];
            Article[] currentArtickes = new Article[2];
            currentArtickes[0] = new Article();
            currentArtickes[1] = new Article(new Persone(), "text", 4);


            for(int i =0; i< currentArtickes.Length; i++)
            {
                //currentArtickes[i] = new Article();
            }



            Console.WriteLine(  );

            //Article a = new Article();
            //Console.WriteLine(a.ToFullString());

            //Persone persone1 = new Persone();
            //Console.WriteLine(persone1.GetName());
            //Console.WriteLine(persone1.GetSurname());
            //Console.WriteLine(persone1.Getdate_of_birth());
        }
    }
}
