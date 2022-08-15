using FluentBuilder.Models;

namespace FluentBuilder.Builders
{
    public class ProductFluentBuilder
    {
        private Product _product = new Product();

        public ProductFluentBuilder WithId(Guid id)
        {
            _product.Id = id;
            return this;
        }
        public ProductFluentBuilder WithName(string name)
        {
            _product.Name = name;
            return this;
        }
        public ProductFluentBuilder WithPrice(decimal price)
        {
            _product.Price = price;
            return this;
        }

        public Product Build()
        {
            return _product;
        }
    }
}
