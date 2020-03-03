using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class Sepet:Base
    {

        [Required]
        [ForeignKey("Kullanicisi")]
        public int KullaniciId { get; set; }

        //navigation properties 
        public virtual Kullanici Kullanicisi { get; set; }
    }
}