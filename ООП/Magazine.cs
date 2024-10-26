using System;

namespace ООП
{
    class Magazine
    {
        private string Name;
        private Frequncy frequncy;
        private DateTime date;
        private int circulation;
        private Article[] articles;
        public Magazine(string n, Frequncy f, DateTime d, int c)
        {
            Name = n;
            frequncy = f;
            date = d;
            circulation = c;
        }

        public Magazine()
        {
            Name = "Time";
            circulation = 10000;
            
        }

        public string GetName()
        {
            return Name;
        }
        public Frequncy Getfreqncy()
        {
            return frequncy;
        }
        
    } 
}
