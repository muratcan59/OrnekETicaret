using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class Iletisim : Base
    {

        [Required]
        [StringLength(25, ErrorMessage = "Ad 2-25 karakter uzunluğunda olmalıdır...", MinimumLength = 2)]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string Mesaj { get; set; }
    }
}