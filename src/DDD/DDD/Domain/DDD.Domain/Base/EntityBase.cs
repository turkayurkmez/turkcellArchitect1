using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Base
{
    public abstract class IAggregateRoot : IEntity
    {
        //Entity'ler bir başka entity ile karşılaştırılabilmeli
        public int Id { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            IEntity entity = obj as IAggregateRoot;
            return entity.GetHashCode() == GetHashCode();
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.Id;
        }
    }

}
