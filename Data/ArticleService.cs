using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedakcniSystem1.Data
{
    public class ArticleService
    {
        public ApplicationDbContext dbcontext { get; set; }
        public List<Article> GetArticles() => dbcontext.Articles.ToList();
        public ArticleService(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public Article GetArticle(int Id) => dbcontext.Articles.FirstOrDefault((ID) => ID.Id == Id);
        public void AddArticle(Article article)
        {
            dbcontext.Articles.Add(article);
            dbcontext.SaveChanges(); 
            
        }
    }
}
