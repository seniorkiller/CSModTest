using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using GenericGameBridge.Factory;
using CSModTest.Managers;
using CitiesGameBridge;


namespace CSModTest 
{
    public static class Constants
    {/*

        public const float BYTE_TO_FLOAT_SCALE = 1f / 255f;
        public static readonly bool[] ALL_BOOL = { false, true };


        public const float SPEED_TO_KMPH = 50.0f; // 1.0f equals 50 km/h

        public static float ByteToFloat(byte b)
        {
            return b * BYTE_TO_FLOAT_SCALE;
        }
        */
        public static IServiceFactory ServiceFactory
        {
            get
            {
#if UNITTEST
                return TestGameBridge.Factory.ServiceFactory.Instance;
#else
                return CitiesGameBridge.Factory.ServiceFactory.Instance;
#endif
            }
        }

        public static IManagerFactory ManagerFactory => Managers.Impl.ManagerFactory.Instance;
    }
}