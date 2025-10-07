using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {
        public Sale()
        {
            
        }
        public Sale (int id, DateTime saleDate, decimal totalPrice, User salesman, Customer customer) : base(id)
        {
            SaleDate = saleDate;
            TotalPrice = totalPrice;
            Salesman = salesman;
            Customer = customer;
        }

        public DateTime SaleDate { get; set; }
        public decimal TotalPrice { get; set; }
        public User Salesman { get; set; }
        public Customer Customer { get; set; }
        public List<SaleItem> SaleItems { get; set; }
    }
    public class SaleItem : BaseEntity<int>
    {
        public SaleItem()
        {
            
        }
        public SaleItem(int id, Sale sale, Product product, decimal quantity, decimal unitPrice, decimal totalPrice) : base(id)
        {
            Sale = sale;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
