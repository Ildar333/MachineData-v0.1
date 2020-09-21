using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Core.Core
{
    public class OS
    {
        public List<string> collection { get; set; } = new List<string>();

        public OS()
        {
            GetSystemData();
        }

        public void GetSystemData()
        {
            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            foreach (ManagementObject obj in objectSearcher.Get())
            {
                collection.Add(obj["Caption"].ToString());
                collection.Add(obj["WindowsDirectory"].ToString());
                collection.Add(obj["ProductType"].ToString());
                collection.Add(obj["SerialNumber"].ToString());
                collection.Add(obj["SystemDirectory"].ToString());
                collection.Add(obj["CountryCode"].ToString());
                collection.Add(obj["CurrentTimeZone"].ToString());
                collection.Add(obj["EncryptionLevel"].ToString());
                collection.Add(obj["OSType"].ToString());
                collection.Add(obj["Version"].ToString());
            }
        }
    }
}
