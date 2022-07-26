﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

    [Table("ProductPhoto")]
    public class ProductPhoto
    {
    public int Id { get; set; }
    public string FileName { get; set; }
    public int ProductId { get; set; }
    [JsonIgnore]
    [ForeignKey("ProductId")]
    public MonAn product { get; set; }
    }

