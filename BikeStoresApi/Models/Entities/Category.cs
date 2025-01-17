﻿using BikeStoresApi.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable

namespace BikeStoresApi.Models.Entities
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
