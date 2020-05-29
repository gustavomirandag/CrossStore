using CrossStore.Domain.Entities;
using CrossStore.Domain.Interfaces.Repositories;
using CrossStore.Infra.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CrossStore.Infra.DataAccess.Repositories.Products
{
    public class SQLiteProductsRepository : EntityFrameworkRepositoryBase<Guid, Product>, IProductRepository
    {
        public SQLiteProductsRepository(string devicePlatform)
        {
            string dbPath = "Filename=";
            const string dbFileName = "crossstore.sqlite";

            switch (devicePlatform)
            {
                case "UWP":
                    dbPath += Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbFileName);
                    break;
                case "iOS":
                    dbPath += Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "data", dbFileName);
                    break;
                case "Android":
                    dbPath += Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), dbFileName);
                    break;
            }

            db = new CrossStoreContext(dbPath);
        }
    }
}
