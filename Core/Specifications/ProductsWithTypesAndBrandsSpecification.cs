using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInClude(x => x.ProductBrand);
            AddInClude(x => x.ProductType);
        }

        public ProductsWithTypesAndBrandsSpecification(int id ) : base(x => x.Id == id)
        {
            AddInClude(x => x.ProductBrand);
            AddInClude(x => x.ProductType);
        }
    }
}