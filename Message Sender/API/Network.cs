using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace MessageSender
{
    static class Network
    {
        public static string GetIPAddress()
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadString("http://icanhazip.com");
            }
        }

        public static string GetMACAddress()
        {
            return NetworkInterface.GetAllNetworkInterfaces()
                    .Where(nic => nic.OperationalStatus == OperationalStatus.Up
                        && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    .Select(nic => nic.GetPhysicalAddress().ToString()).FirstOrDefault();
        }
    }
}
