using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrafficManager.Manager;
using ColossalFramework;
using ColossalFramework.IO;

namespace CSModTest.Managers
{
    /*public class DataManagerTest2 : SimulationManagerBase<CitizenManager, CitizenProperties>, ISimulationManager, IRenderableManager, IAudibleManager
    {
        public class Data : IDataContainer
        {
            public void Serialize(DataSerializer s)
            {
                Singleton<LoadingManager>.instance.m_loadingProfilerSimulation.BeginSerialize(s, "DataManager");
                DataManager instance = Singleton<DataManager>.instance;
                Citizen[] buffer = instance.m_citizens.m_buffer;
                CitizenUnit[] buffer2 = instance.m_units.m_buffer;
            }
            public void Deserialize(DataSerializer s)
            {

            }
            public void AfterDeserialize(DataSerializer s)
            {

            }


            private void Start()
            {
                m_data = new Array16<CitizenData>(999);

            }
            public Array16<CitizenData> m_data;


        }
    }*/
}
