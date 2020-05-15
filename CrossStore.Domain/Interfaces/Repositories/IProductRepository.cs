using CrossStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Guid,Product>
    {
    }
}
