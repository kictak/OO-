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

        public Article(Persone p, string t, double r)
        {
            persone = p;
            title = t;
            rating = r;
        }

        public Article()
        {
            title = "Time";
            rating = 9.4;
        }

        public string Article.ToFullString()
        {

        }
    }
}
