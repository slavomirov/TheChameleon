namespace TheChameleon.Data.Common.Models
{
    using System;

    public interface BaseDeletableModel
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
