using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class BlogYorum :Base
    {
       [Required]
       [ForeignKey("Blogu")]
        public int BlogId { get; set; }
        [StringLength(75, ErrorMessage = "Başlık 2 -75 arası karaktere sahip olmalı ", MinimumLength = 2)]
        [Required]
        public string Baslik { get; set; }
        [Required]
        public string Icerik { get; set; }
       
       //navigation properties
       public virtual Blog Blogu { get; set; }
    }
}