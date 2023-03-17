using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class WMIManager
    {
        public string SendRequest(string req, string prop)
        {
            string result = string.Empty;
            if (!string.IsNullOrWhiteSpace(req) && !string.IsNullOrWhiteSpace(prop))
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(req);
                ManagementObjectCollection objects = searcher.Get();
                foreach (ManagementObject obj in objects)
                {
                    result = obj.GetPropertyValue(prop).ToString();
                }
            }
            return result;
        }
    }
}
