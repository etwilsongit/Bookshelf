using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookshelfMVC.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}