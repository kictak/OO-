using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    class Article
    {
        public Persone persone;
        public string title;
        public double rating;
        
        public Article(Persone persone, string title, double rating)
        {
            this.persone = persone;
            this.title = title;
            this.rating = rating;
        }

        public Article()
        {
            persone = new Persone();
            title = "Time";
            rating = 9.4;
        }

        public string ToFullString()
        {
            //return $"статья такая то... рейтинг такой. автор: тут поля из персона";
            return persone.ToFullString() + "  " + title + " " + rating;
        }
    }
}
