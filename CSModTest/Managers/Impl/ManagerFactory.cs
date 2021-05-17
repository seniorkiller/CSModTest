using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrafficManager.Manager;
using TrafficManager.API.Manager;
using ColossalFramework;
using UnityEngine;
using CSModTest.Managers;

namespace CSModTest.Managers.Impl
{
    public class ManagerFactory : IManagerFactory
    {
        public static IManagerFactory Instance = new ManagerFactory();

        public IDataManager CitizenDatas => DataManager.Instance;

    }
}