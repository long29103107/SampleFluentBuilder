using FluentBuilder.Models;

namespace FluentBuilder.Builders
{
    public class ProductBuilder
    {
        private Product _product = new Product();

        public void AddId(Guid id)
        {
            _product.Id = id;
        }

        public void AddName(string name)
        {
            _product.Name = name;
        }

        public void AddPrice(decimal price)
        {
            _product.Price = price;
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}
