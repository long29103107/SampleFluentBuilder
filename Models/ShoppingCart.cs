namespace FluentBuilder.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }

        public List<Product> Items { get; set; }

        public double Discount { get; set; }

        public User User { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Items: {Items.Count}, Discount: {Discount}, User: {User.Email}";
        }
    }
}
