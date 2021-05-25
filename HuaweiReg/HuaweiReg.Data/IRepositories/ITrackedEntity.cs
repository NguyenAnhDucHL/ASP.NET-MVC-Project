using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiReg.Data.IRepositories
{
    public interface ITrackedEntity
    {
        DateTime LastUpdatedDate { get; set; }
        string LastUpdatedBy { get; set; }
    }
}
