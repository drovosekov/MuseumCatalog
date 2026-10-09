using System;
using System.Net.NetworkInformation;
using System.Text;

namespace MuseumCatalog.Services
{
    public static class PCIdentifierService
    {
        public static string Generate()
        {
            string machineName = Environment.MachineName;
            string userName = Environment.UserName;
            string mac = GetMacAddress();

            return machineName + "\\" + userName + " (" + mac + ")";
        }

        private static string GetMacAddress()
        {
            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up
                    && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    var mac = nic.GetPhysicalAddress();
                    string hex = mac.ToString();
                    if (hex.Length == 12)
                    {
                        var sb = new StringBuilder();
                        for (int i = 0; i < 12; i += 2)
                        {
                            if (i > 0) sb.Append(':');
                            sb.Append(hex.Substring(i, 2));
                        }
                        return sb.ToString();
                    }
                }
            }
            return "00:00:00:00:00:00";
        }
    }
}
