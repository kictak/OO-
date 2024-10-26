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
        public Magazine(string n, Frequncy f, DateTime d, int c, Article[] a)
        {
            Name = n;
            frequncy = f;
            date = d;
            circulation = c;
            articles = a;
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

        public DateTime GetDataTime()
        {
            return date;
        }

        public int Getcirculation()
        {
            return circulation;
        }
        public Article[] GetArticles()
        {
            return articles;
        }

        public double GetRating()
        {
            int length = articles.Length;
            double sum = 0;
            for (int a = 0 ; a < length; a ++ )
            {
                sum += articles[a].rating;
            }
            sum = sum / articles.Length;
            
            return sum;
        }
        //метод void AddArticles(params Article[]) для добавления элементов в список статей в журнале;
        void AddArticles (params Article[] articles) 
        {
            
        }
    }
}
