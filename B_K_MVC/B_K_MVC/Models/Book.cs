using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace B_K_MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Isbn { get; set; }
       /// <summary>
       /// 摘要
       /// </summary>
        public string Synopsis { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual Author Author { get; set; }
        public string Title { get; set; }
    }
}