using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICities;
using UnityEngine;
using CSModTest.Managers.Impl;


namespace CSModTest
{
    public class ModName : IUserMod
    {
        public string Name => "OnSettingUITest";
        public string Description => "please work";
        public void OnSettingsUI(UIHelperBase helper)
        {    
            helper.AddGroup("Manual Testing");
            //helper.AddButton("Check 1 Citizen Cord", DoSomething.Checkcord);
            //helper.AddTextfield("Enter InstanceID", "", text => DoSomething.Checkcord(Convert.ToUInt32(text))) ;
            
            helper.AddButton("Awake", DataManager.Instance.Awake);
            helper.AddButton("Peridic Cord Check", DataManager.Instance.PeriodicCordCheck);
            helper.AddTextfield("Citizen Test1 InstanceID", "", text => DataManager.Instance.CitizenCount = Convert.ToInt32(text));
            helper.AddButton("Print Data", DataManager.Instance.PrintData);

        }
    }
    public class DoNothing
    {
        public static void Donothing() { }
        


    }
}
