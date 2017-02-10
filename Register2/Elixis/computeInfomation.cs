using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
namespace Elixis
{
    public class computeInfomation
    {
        
        #region 获取机器名
        /// <summary>
        /// 获取机器名
        /// </summary>
        /// <returns>机器名称</returns>
　      public string GetHostName()
        {
        return System.Net.Dns.GetHostName();
        }
        #endregion
        #region 获取ＣＰＵ编号
        /// <summary>
       /// 获取cpu编号
        /// </summary>
        /// <returns></returns>
　      public string GetCPUId()
            {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc=mc.GetInstances();

            String strCpuID=null;
            foreach(ManagementObject mo in moc)
            {
              strCpuID=mo.Properties["ProcessorId"].Value.ToString();
            break;
            }
            return strCpuID;
            }

        #endregion
        #region 获取主硬盘编号
        /// <summary>
       /// 获取主硬盘编号
        /// </summary>
        /// <returns></returns>
        public string GetMainHardDiskId()
        {
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
        String strHardDiskID=null;
        foreach(ManagementObject mo in searcher.Get())
        { 
        strHardDiskID=mo["SerialNumber"].ToString().Trim();
        break; 
        }
        return strHardDiskID;
        }
        #endregion

    }
}
