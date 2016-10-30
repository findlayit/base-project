using System;

namespace BaseProject.Domain
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}