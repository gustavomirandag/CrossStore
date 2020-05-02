using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStoreApp.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Photo { get; set; }
        public Decimal Price { get; set; }
    }
}
