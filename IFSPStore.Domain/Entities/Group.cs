using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Group : BaseEntity<int>
    {
        public Group(int id, string name) : base(id)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
