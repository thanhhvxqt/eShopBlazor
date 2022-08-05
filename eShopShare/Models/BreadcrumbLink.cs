using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopShare.Models
{
    public class BreadcrumbLink
    {
        public int OrderIndex { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
