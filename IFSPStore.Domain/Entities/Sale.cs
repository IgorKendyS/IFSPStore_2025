using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {
        public Sale (int id, DateTime data, decimal totalPrice, User user, Customer customer) : base(id)
        {
            Data = data;
            TotalPrice = totalPrice;
            User = user;
            Customer = customer;
        }

        public DateTime Data { get; set; }
        public decimal TotalPrice { get; set; }
        public User User { get; set; }
        public Customer Customer { get; set; }
    }
}
