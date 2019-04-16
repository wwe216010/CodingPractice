using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;

namespace MvcApplication1.Models
{
    public class ArticlesFactory
    {
        public Articles CreateArticles(Bulletin bulletin)
        {
            Articles articles = new Articles
            {
                Author = "Bill",
                Title = "WWW",
                Content = "Bill have a pen",
                PostOn = DateTime.Now
            };

            SilencerAttribute a =null;
            Attribute[] Aryattr = Attribute.GetCustomAttributes(bulletin.GetType());
            foreach (var item in Aryattr)
            {
                if (item is SilencerAttribute)
                {
                    a = item as SilencerAttribute;                    
                }
            }

            switch (a.Mode)
            {
                case SilencerMode.Normal:
                    articles.Author = "Bi○○";
                    articles.Title = "W○○";
                    articles.Content = "Bill have a ○○○";
                    articles.PostOn = DateTime.Now;
                    break;
                case SilencerMode.Strict:
                    articles.Author = "B○○○";
                    articles.Title = "W○○";
                    articles.Content = "○○○ have a ○○○";
                    articles.PostOn = DateTime.Now;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    break;
            }


            return articles;
        }
    }

    public class Articles
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostOn { get; set; }
    }
}