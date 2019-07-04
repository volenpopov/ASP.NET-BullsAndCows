using System;

namespace BullsAndCows.Data.Common
{
    public interface IAuditableEntity
    {
        DateTime CreatedOn { get; set; }
    }
}
