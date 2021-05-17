using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using UnityEngine;
namespace CSModTest.Utils
{
    public class ExcelUtils
    {
        public static void CreateNo(int nocount, ExcelWorksheet x,int rowstart,int colomstart)
        {
            try
            {
                for(int i = 0; i < nocount; i++)
                {
                    x.Cells[rowstart+i, colomstart ].Value = i + 1;
                }
            }
            catch(Exception e) { Debug.Log(e.Message); }
        }
    }
}
