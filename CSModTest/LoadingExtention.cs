using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICities;
using UnityEngine;
using TrafficManager;
using TrafficManager.API.Manager;
using System.Reflection;
using CSModTest.Managers.Impl;

namespace CSModTest
{
    public class LoadingExtention: LoadingExtensionBase
    {
        public static List<ICustomManager> RegisteredManagers { get; private set; }
        internal static LoadingExtention Instance = null;

        public override void OnCreated(ILoading loading)
        {
            base.OnCreated(loading);                     
            RegisteredManagers = new List<ICustomManager>();            
            RegisterCustomManagers();
            Instance=this;
        }
        public override void OnLevelLoaded(LoadMode mode)
        {
            
            CitizenManager Cman = CitizenManager.instance;
            int Valid = 0;
            for (uint i = 0; i < Cman.m_citizens.m_buffer.GetUpperBound(0); i++)
            {
                if (DoSomething.IsCitizenValid(i)) { Valid++; }
            }
            Debug.Log(Valid);
            try { DataManager.Instance.Awake(); } catch(Exception e) { Debug.Log(e); }



        }
        private void RegisterCustomManagers() 
        {
            RegisteredManagers.Add(DataManager.Instance);
           
        }
    }
}


