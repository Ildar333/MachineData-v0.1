using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Core.Core
{
    public class GPU
    {
        public List<string> collection { get; set; } = new List<string>();

        ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_VideoController");

        public GPU()
        {
            ReturnGPU();
        }

        public void ReturnGPU() 
        {
            foreach (ManagementObject obj in searcher.Get())
            {
                collection.Add(obj["Name"].ToString());
                collection.Add(obj["Status"].ToString());
                collection.Add(obj["Caption"].ToString());
                collection.Add(obj["DeviceID"].ToString());
                collection.Add(obj["AdapterRAM"].ToString());
                collection.Add(obj["AdapterDACType"].ToString());
                collection.Add(obj["Monochrome"].ToString());
                collection.Add(obj["InstalledDisplayDrivers"].ToString());
                collection.Add(obj["DriverVersion"].ToString());
                collection.Add(obj["VideoProcessor"].ToString());
                collection.Add(obj["VideoArchitecture"].ToString());
                collection.Add(obj["VideoMemoryType"].ToString());
            }
        }
    }
}
