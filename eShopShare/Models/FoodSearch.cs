using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopShare.Models
{
    public class FoodSearch: PagingParameters
    {
        public string Name { get; set; }

        public Guid? AssigneeId { get; set; }

        public MonAn.PhanLoai? PhanLoai { get; set; }
    }
}
