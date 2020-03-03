using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class Blog:Base
    {
        public Blog()
        {
            this.Yorumlari = new HashSet<BlogYorum>();
        }
        public int KategoriId { get; set; }
        public int KullaniciId { get; set; }
        [Required]
        public string Baslik { get; set; }
        [Required]
        public string Icerik { get; set; }

        //nav properties
        [ForeignKey("KategoriId")]
        public virtual Kategori Kategorisi { get; set; }
        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanicisi { get; set; }
        public virtual ICollection<BlogYorum> Yorumlari { get; set; }
    }
}