using System;
using System.Collections.Generic;
using System.Text;
using TimeEssentials.Core;

namespace TimeEssentials.Data
{
    public interface IBaseEssentialsData
    {
        IEnumerable<BaseEssentials> GetAllEquilibrium();
    }
}
