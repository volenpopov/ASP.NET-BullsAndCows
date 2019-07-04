using System;

namespace BullsAndCows.Data.Common
{
    public abstract class BaseModel<TKey> : IAuditableEntity
    {
        public TKey Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
