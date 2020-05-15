using CrossStore.Domain.Entities;
using CrossStore.Domain.Interfaces.Repositories;
using CrossStore.Infra.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Infra.DataAccess.Repositories.Products
{
    public class AzureSqlServerProductsRepository : EntityFrameworkRepositoryBase<Guid,Product>, IProductRepository
    {
        public AzureSqlServerProductsRepository()
            :base(new CrossStoreContext("Server=tcp:crossstore-db-server-gustavo.database.windows.net,1433;Initial Catalog=crossstore-db;Persist Security Info=False;User ID=daniel;Password=@dsInf123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
        {
        }
    }
}
