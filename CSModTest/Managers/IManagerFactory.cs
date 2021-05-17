using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSModTest.Managers
{
    public interface IManagerFactory
    {
        IDataManager CitizenDatas { get; }
    }
}
