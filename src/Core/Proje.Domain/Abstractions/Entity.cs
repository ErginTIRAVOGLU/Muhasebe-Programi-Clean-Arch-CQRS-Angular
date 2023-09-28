using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Abstractions
{
    public abstract class Entity
    {
        public string Id { get; set; }= Guid.NewGuid().ToString();
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set;}
        public DateTime? DeletedDate { get; set; }

        
    }
}
