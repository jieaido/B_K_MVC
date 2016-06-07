using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B_K_MVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// 传记
        /// </summary>
        public string Biography { get; set; }
        public virtual  ICollection<Book> Books { get; set; }
    }
}