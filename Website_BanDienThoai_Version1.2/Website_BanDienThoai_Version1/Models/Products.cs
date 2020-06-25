using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Website_BanDienThoai_Version1.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int? Memory { get; set; }
        public int? Quantity { get; set; }
        public int? Capacity { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Display(Name = " Product Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = " Product Special")]
        public int SpecialTagId { get; set; }
        [ForeignKey("SpecialTagId")]
        public virtual SpecialTag SpecialTag { get; set; }

          }
}
