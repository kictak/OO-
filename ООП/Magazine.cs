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
        public Magazine(string name, Frequncy frequncy, DateTime date, int circulation, Article[] articles)
        {
            this.Name = name;
            this.frequncy = frequncy;
            this.date = date;
            this.circulation = circulation;
            this.articles = articles;
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

        void AddArticles (params Article[] newArticles) 
        {
            //Article[] currentArtickes = new Article[2];
            //currentArtickes[0] = new Article();
            //currentArtickes[1] = new Article(new Persone(), "", 0);
            Article[] tmp;
            tmp = new Article[articles.Length + newArticles.Length];
            for (int i = 0; i < articles.Length; i++)
            {
                tmp[i] = articles[i];
            }
            for (int i = 0; i < newArticles.Length; i++)
            {
                tmp[articles.Length + i] = newArticles[i];
            }
            articles = tmp;
        }
    }
}
