using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CSModTest
{
    public class Configuration
    {
        [Serializable]
        public class CitizenData
        {
            public Vector2[] Cord;
            public uint Citizenid;
            public uint Instanceid;
        }
        public List<CitizenData> CitizenDatas= new List<CitizenData>();
    }
}
