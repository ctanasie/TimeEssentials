using System;
using System.Collections.Generic;
using System.Text;
using TimeEssentials.Core;

namespace TimeEssentials.Data
{
    public class InMemoryBaseEssentialsData : IBaseEssentialsData
    {
        public IEnumerable<BaseEssentials> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
