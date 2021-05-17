using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CSModTest.Managers.Impl
{
    public class CitizenDataClass
    {
        public Vector2[] Cord;
        public uint Citizenid;
        public uint Instanceid;
        public CitizenDataClass()
        {

        }
        public CitizenDataClass(uint cid)
        {
            Citizenid = cid;
            Instanceid = CitizenManager.instance.m_citizens.m_buffer[cid].m_instance;
            Cord = new Vector2[DataManager.Instance._cordArrayNum];
        }
        public void CordArrayShift()
        {
            Array.Copy(Cord, 1, Cord, 0, Cord.GetUpperBound(0));
        }
      

    }
}
