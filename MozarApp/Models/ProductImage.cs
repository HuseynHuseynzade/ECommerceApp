﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models
{
    [Table(name:"Images",Schema ="dbo")]
    public class ProductImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

    }
}
