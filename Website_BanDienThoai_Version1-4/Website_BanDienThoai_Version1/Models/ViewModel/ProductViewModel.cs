using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website_BanDienThoai_Version1.Models.ViewModel
{
    public class ProductViewModel
    {
        public Products Products { get; set; }
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<SpecialTag> SpecialTag { get; set; }
    }
}
