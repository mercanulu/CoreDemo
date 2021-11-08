using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
  public class Category
    {

        //erişim belirleyici türü - Değişken türü - isim {get set}
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
