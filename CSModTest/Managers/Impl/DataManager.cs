using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CSModTest.Manager;
using ColossalFramework;
using UnityEngine;
using OfficeOpenXml;
using CSModTest.Utils;



namespace CSModTest.Managers.Impl
{
    public class DataManager : AbstractCustomManager,
           IDataManager
          

    {
        private DataManager() 
        {            
            CitizenDatas = new CitizenDataClass[CitizenManager.MAX_CITIZEN_COUNT];
            ncord = 0;
        }
        public static DataManager Instance = new DataManager();
        public CitizenDataClass[] CitizenDatas { get; set; }

        public int _cordArrayNum = 5;

        public int ncord;

        public int CitizenCount;
       
        public bool IsAwake;


        private bool IsValid(uint cid)
        {
            return DoSomething.IsCitizenValid(cid);
        }



        public void Awake()
        {
            if (!IsAwake)
            {
                CitizenManager Cman = CitizenManager.instance;

                int CitizenCount = Cman.m_citizenCount;
                uint[] cid = new uint[CitizenCount];
                int nCitizen = 0;


                for (uint i = 0; i < Cman.m_citizens.m_buffer.GetUpperBound(0); i++)
                {
                    if (IsValid(i)) { cid[nCitizen] = i; nCitizen++; }
                }


                Instance.CitizenCount = CitizenCount;


                try
                {
                    for (int n = 0; n < CitizenCount; n++)
                    {
                        CitizenDatas[n] = new CitizenDataClass(cid[n]);
                        Debug.Log("Class Created");
                    }

                }
                catch (Exception e)
                {
                    Debug.Log(e);

                } IsAwake = true;
            }
            else { Debug.Log("already awake"); }
        }
     
        public void PeriodicCordCheck() 
        {
            if (ncord <= _cordArrayNum-1) 
            {
                for (int i = 0; i < CitizenCount; i++)
                {
                    CitizenDataClass CD = CitizenDatas[i];
                    CD.Cord[ncord] = DoSomething.Getcord(CD.Instanceid);
                }ncord++;
            }
            if (ncord == _cordArrayNum)
            {
                for (int i = 0; i < CitizenCount; i++)
                {
                    CitizenDataClass CD = CitizenDatas[i];
                    CD.CordArrayShift();
                    CD.Cord[ncord-1] = DoSomething.Getcord(CD.Instanceid);
                }
            }
            Debug.Log(ncord);
              
        }

        public void PrintData()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
           
            using (var package = new ExcelPackage()) 
            {
                var workbook = package.Workbook.Worksheets.Add("Data");
                workbook.Cells[1, 1].Value = "No";
                workbook.Cells[1,2].Value = "Name";
                workbook.Cells[1,3].Value = "InstanceID";
                workbook.Cells[1,4].Value = "CitizenID";
                Debug.Log("Top almost Created");
                for(int i = 0; i < _cordArrayNum ; i++)
                {
                    int num = i + 5;
                    int num2 = i + 1;
                    workbook.Cells[1,num].Value = "Location"+num2;
                }
                
                Debug.Log("Top Created");
                ExcelUtils.CreateNo(CitizenCount, workbook, 1, 2);
                Debug.Log("No Created");
                
                

                for (int i = 0; i < CitizenCount; i++) 
                {
                    CitizenDataClass cd = CitizenDatas[i];
                    if (IsValid(cd.Citizenid))
                    {
                        for (int n = 0; n < _cordArrayNum; n++)
                        {
                            int colomn = i + 2;
                            int row =n+5;
                            workbook.Cells[colomn, row].Value = cd.Cord[n];
                        }
                        Debug.Log("A Citizen Cord Created");
                    }
                    

                }
                Debug.Log("Finish");
                DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Rafif\Documents\Testing Data\");
                FileInfo Name = new FileInfo(dir + @"Datass.xlxs");
                try
                { package.SaveAs(Name); } catch(Exception e) { Debug.Log(e);Debug.Log(e.Message); }
            }
        }

        public override void OnLevelUnloading()
        {
            base.OnLevelUnloading();
            
        }
       

    }
}
