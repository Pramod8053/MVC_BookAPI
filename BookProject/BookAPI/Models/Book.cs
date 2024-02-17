using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAPI.Models
{
    public class Book
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}