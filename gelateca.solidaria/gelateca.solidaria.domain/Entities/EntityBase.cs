using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gelateca.solidaria.domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
        public string Description { get; protected set; }
    }
}
