using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category (int id, Sale sale, Product product, int quantity, decimal unitPrice, decimal totalPrice) : base(id)
        {
            Sale = sale;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
