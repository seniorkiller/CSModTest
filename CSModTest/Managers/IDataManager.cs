using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSModTest.Managers.Impl;

namespace CSModTest.Managers
{
    public interface IDataManager
    {
        CitizenDataClass[] CitizenDatas { get; set; }

        
    }
}
