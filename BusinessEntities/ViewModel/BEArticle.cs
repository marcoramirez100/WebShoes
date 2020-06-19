using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace BusinessEntities.Models
{
    [DisplayName("articles")]
    public class BEArticle
    {
        public int id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int total_in_shelf { get; set; }
        public int total_in_vault { get; set; }
        public short store_id { get; set; }
        public string store_name { get; set; }
    }
}