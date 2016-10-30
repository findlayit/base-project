using System;

namespace BaseProject.BusinessProvider.Common
{
    public class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}