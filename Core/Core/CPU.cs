using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Core.Core
{
    public class CPU
    {
        public List<string> result { get; set; }

        ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");

        public CPU()
        {
            result = new List<string>();
            ReturnCPU();
        }

        public List<string> ReturnCPU()
        {

            foreach (ManagementObject obj in searcher.Get())
            {
                result.Add(obj["Name"].ToString());
                result.Add(obj["DeviceID"].ToString());
                result.Add(obj["Manufacturer"].ToString());
                result.Add(obj["CurrentClockSpeed"].ToString());
                result.Add(obj["Caption"].ToString());
                result.Add(obj["NumberOfCores"].ToString());
                result.Add("---");
                result.Add(obj["Architecture"].ToString());
                result.Add(obj["Family"].ToString());
                result.Add(obj["ProcessorType"].ToString());
                result.Add("---");
                result.Add(obj["AddressWidth"].ToString());
            }

            return result;
        }
    }
}
