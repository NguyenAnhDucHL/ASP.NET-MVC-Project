using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiReg.Data
{
    public interface IDbContextFactory<T>
    {
        T GetContext();
    }
}
