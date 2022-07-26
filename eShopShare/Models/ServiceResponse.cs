﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopShare.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public string AddressEmail { get; set; }
    }
}
