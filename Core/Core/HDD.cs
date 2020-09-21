using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Core.Core
{
    public class HDD
    {
        public List<List<string>> collection { get; set; } = new List<List<string>>();
        public int driversCount = DriveInfo.GetDrives().Count();

        public HDD()
        {
            ReturnHDD();
        }

        static readonly string[] SizeParameters = {"bytes","KB","MB","GB","TB","PB","EB","ZB","YB"};

        public string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value ==0) { return "0.0 bytes"; }

            var mag = (int)Math.Log(value, 1024);
            decimal adjustedValue = (decimal)value / (1L << mag * 10);

            return string.Format("{0:n1}", adjustedValue, SizeParameters[mag]);
        }

        public void ReturnHDD()
        {
            for (int j = 0; j < driversCount; j++)
                collection.Add(new List<string>());

            int i = 0;

            DriveInfo[] allDrivers = DriveInfo.GetDrives();

            foreach (DriveInfo driver in allDrivers) 
            {
                collection[i].Add(driver.Name);
                collection[i].Add(driver.DriveType.ToString());

                if (driver.IsReady)
                {
                    collection[i].Add(driver.VolumeLabel);
                    collection[i].Add(driver.DriveFormat);
                    collection[i].Add(driver.AvailableFreeSpace.ToString());
                    collection[i].Add(driver.TotalFreeSpace.ToString());
                    collection[i].Add(SizeSuffix(driver.TotalSize));
                    collection[i].Add(driver.RootDirectory.ToString());
                }

                i++;
            }
        }
    }
}
