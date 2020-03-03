using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class Urun :Base
    {
        public Urun()
        {
            this.Yorumlari = new HashSet<UrunYorum>();
            this.Fotograflari = new HashSet<Fotograf>();
        }
        [Required]
        [StringLength(25, ErrorMessage = "Ad 2-25 karakter uzunluğunda olmalıdır.", MinimumLength = 2)]
        public string Adi { get; set; }
        [Required]
        public int Fiyati { get; set; }
        [Required]
        //[ForeignKey("Kategorisi")]
        public int KategoriId { get; set; }
        [Required]
        public string Marka { get; set; }
        public string Modeli { get; set; }
        public string Stok { get; set; }
        public string Aciklama { get; set; }

        //navigation properties
        [ForeignKey("KategoriId")]
        public virtual Kategori Kategorisi { get; set; }

        public virtual ICollection<UrunYorum> Yorumlari { get; set; }
        public virtual ICollection<Fotograf> Fotograflari { get; set; }
    }
}