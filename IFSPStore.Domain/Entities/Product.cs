using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product (int id, string name, decimal price, float quantity, DateOnly buyDate, string unitSold, Group group) : base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            BuyDate = buyDate;
            UnitSold = unitSold;
            Group = group;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }
        public DateOnly BuyDate { get; set; }
        public string UnitSold { get; set; }
        public Group Group { get; set; }
    }
}
