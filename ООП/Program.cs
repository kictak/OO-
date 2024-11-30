using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    internal class Program
    {
        //static void Main(string[] args)        
        //{ 
        //    Magazine magazineObj = new Magazine();
        //    string magazineOpisanie = magazineObj.ToShortString();
        //    Console.WriteLine(magazineOpisanie);
        //    Magazine magazineObj2 = new Magazine();
        //    magazineObj2.SetName("Pravda");
        //    magazineObj2.SetFreqncy(Frequncy.Yerly);
        //    magazineObj2.SetDataTime(new DateTime(2232, 02, 20));
        //    magazineObj2.Setcirculation(102);

        //    //Book b1 = new Book( “Война и мир”, 18xx

        //    Persone persone = "Cowboy";

        //    Article[] articles2 = new Article[2];

        //    articles2[0] = new Article();
        //    articles2[1] = new Article(Persone persone, string "", 5);

        //    magazineObj2.SetArticles(articles2);
        //    string magazineOpisanie2 = magazineObj2.ToShortString();
        //    Console.WriteLine(magazineOpisanie2);

        static void Main(string[] args)
        
        {
            Console.WriteLine("Введите university");
            string university = Console.ReadLine();

            Console.WriteLine("Введите Name");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите date");
            string date = Console.ReadLine();
            
            DateTime date_of_birth = DateTime.Parse(date);
            

            Persone p = new Persone(name, surname, date_of_birth);
            p.Display();


            Student s = new Student(university);
            s.Display();
        }


    }
}
