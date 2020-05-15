using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Domain.Entities
{
    public class Product : EntityBase<Guid>
    {
        public String Name { get; set; }
        public String Photo { get; set; }
        public Decimal Price { get; set; }
    }
}
