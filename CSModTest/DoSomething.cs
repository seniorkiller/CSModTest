using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using CSModTest.Managers.Impl;


namespace CSModTest
{

    public class DoSomething
    {
        
        public static bool IsCitizenValid(uint citizenId)
        {           
            return CheckCitizenFlags(citizenId, Citizen.Flags.Created);
        }
        public static Vector3 Getcord(uint InstanceID)
        {
            CitizenManager Cman = CitizenManager.instance;
            Vector2 cord = Cman.m_instances.m_buffer[InstanceID].m_targetPos;
            return cord;
        }
        public static bool CheckCitizenFlags(uint citizenId, Citizen.Flags flagMask, Citizen.Flags? expectedResult = null)
        {

            Citizen.Flags result =CitizenManager.instance.m_citizens.m_buffer[citizenId].m_flags
                & flagMask;

            return expectedResult == null ? result != 0 : result == expectedResult;
        }

    }
    
}

