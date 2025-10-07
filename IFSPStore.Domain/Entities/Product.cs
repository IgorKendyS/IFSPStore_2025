using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product()
        {
            
        }
        public Product (int id, string name, decimal price, decimal  quantity, DateTime buyDate, string unitSold, Category category) : base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            BuyDate = buyDate;
            UnitSold = unitSold;
            Category = category;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime BuyDate { get; set; }
        public string UnitSold { get; set; }
        public Category Category { get; set; }
    }
}
