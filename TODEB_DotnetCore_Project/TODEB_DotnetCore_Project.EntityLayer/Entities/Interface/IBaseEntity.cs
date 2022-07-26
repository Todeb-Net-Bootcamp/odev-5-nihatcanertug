using System;

namespace TODEB_DotnetCore_Project.EntityLayer.Entities.Interface
{
    public interface IBaseEntity //Base Interface
    {
        DateTime CreateDate { get; set; }
        DateTime? UpdateDate { get; set; }
        DateTime? DeleteDate { get; set; }
    }
}
