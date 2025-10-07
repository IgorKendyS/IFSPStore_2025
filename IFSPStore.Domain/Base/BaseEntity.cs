using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Domain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity
    {
        protected BaseEntity()
        {
            
        }
        protected BaseEntity(TId id) {
            Id = id;
        }

        public TId Id { get; set; }
    }
}
