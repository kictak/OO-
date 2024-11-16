using System;

namespace ООП
{
    class Magazine
    {
        private string name;
        private Frequncy frequncy;
        private DateTime date;
        private int circulation;
        private Article[] articles;
        public Magazine(string name, Frequncy frequncy, DateTime date, int circulation, Article[] articles)
        {
            this.name = name;
            this.frequncy = frequncy;
            this.date = date;
            this.circulation = circulation;
            this.articles = articles;
        }


        public Magazine()
        {
            name = "Time";
            date = new DateTime(2002, 02, 20);
            circulation = 10000;
            articles = new Article [0];
        }
        public void SetName(string value)
        {
            name = value;
        }
        public string GetName()
        {
            return name;
        }
        public void SetFreqncy(Frequncy value)
        {
            frequncy = value;
        }
        public Frequncy GetFreqncy()
        {
            return frequncy;
        }
        public void SetDataTime(DateTime value)
        {
            date = value;
        }
        public DateTime GetDataTime()
        {
            return date;
        }
        public void Setcirculation(int value)
        {
            circulation = value;
        }
        public int GetCirculation()
        {
            return circulation;
        }
        public void SetArticles(Article[] value)
        {
            articles = value;
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

        public string ToFullString()
        {
            return GetName() + "  " + GetFreqncy() + " " + GetDataTime() + " " + GetCirculation() + " " + GetArticles();
        }

        public string ToShortString()
        {
            return GetName() + "  " + GetFreqncy() + " " + GetDataTime() + " " + GetCirculation() + " " + GetRating();
        }
    }
}
