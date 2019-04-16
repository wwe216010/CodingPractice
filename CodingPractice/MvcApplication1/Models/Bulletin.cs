using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public abstract class Bulletin
    {
        protected Bulletin()
        {
            ArticlesFactory articlesFactory = new ArticlesFactory();
            Article = articlesFactory.CreateArticles(this);
        }

        public Articles Article { get; set; }
        public string Description { get; set; }
    }
}