using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedakcniSystem1.Data
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public bool IsVisible { get; set; }


        public Article(string Title, string Author, DateTime Created, string ImageUrl, string Content, bool IsVisible)
        {
            this.Title = Title;
            this.Author = Author;
            this.Created = DateTime.Now;
            this.ImageUrl = ImageUrl;
            this.Content = Content;
            this.IsVisible = IsVisible;
        }
        public Article()
        {
                
        }

    }
}
