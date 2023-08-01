﻿using Data;
using Entitites.Entities;
using WebApplication1.IServices;


namespace WebApplication1.Services
{
    public class ProductService : BaseContextService, IProductService
    {
        public ProductService(ServiceContext serviceContext) : base(serviceContext)
        {
        }

        public void DeleteDetalle(int ProductsId)
        {
            throw new NotImplementedException();
        }

        public int insertProduct(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
            return productItem.Id;
        }

        public void UpdateProduct(ProductItem Products)
        {
            throw new NotImplementedException();
        }
    }
}
