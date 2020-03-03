using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class Fotograf:Base
    {
        [Required]
        [StringLength(250, ErrorMessage = "URL maksimum 250 karakter uzunluğunda olmalıdır.", MinimumLength = 5)]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        [Required]
        [ForeignKey("Urunu")]
        public int UrunId { get; set; }

        //navigation properties
        public virtual Urun Urunu { get; set; }
    }
}