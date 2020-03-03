using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETicaret.Model
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        [DefaultValue("12-12-2012")]
        public DateTime KayitTarihi { get; set; }
        [DefaultValue(false)]
        public bool IsDelete { get; set; }

    }
}