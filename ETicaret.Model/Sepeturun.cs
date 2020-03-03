using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class SepetUrun:Base
    {
        [Required]
        public int SepetId { get; set; }
        [Required]
        public int UrunId { get; set; }
        [Required]
        public int Miktar { get; set; }

        //navigation prop
        [ForeignKey("SepetId")]
        public virtual Sepet Sepeti { get; set; }
        [ForeignKey("UrunId")]
        public virtual Urun Urunu { get; set; }
    }
}