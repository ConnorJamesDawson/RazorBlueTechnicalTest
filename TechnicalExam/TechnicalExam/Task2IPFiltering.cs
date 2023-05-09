using System.Text.RegularExpressions;

namespace TechnicalExam;

public class Task2IPFiltering
{
    public static bool FilterIP(string ip = null, string cidr = null)
    {
        string exampleMinIp = "192.168.1.15"; //If working with a database these values would be gotten from said database
        string exampleMaxIp = "192.168.1.205";
        // exampleCIDR = "192.168.1.0/24";

        List<string> ipList = ip.Split(".").ToList();
        List<string> minIpList = exampleMinIp.Split(".").ToList();
        List<string> maxIpList = exampleMaxIp.Split(".").ToList();

        List<int> ipNumbers = ipList.ConvertAll(int.Parse);
        List<int> minIpNumbers = minIpList.ConvertAll(int.Parse);
        List<int> maxIpNumbers = maxIpList.ConvertAll(int.Parse);
        if(cidr != null)
        {
            List<string> Cidr = cidr.Split(".").ToList();
            List<string> range = Cidr[3].Split("/").ToList();
            List<int> rangenumbers = range.ConvertAll(int.Parse);

            if (ipNumbers[3] > rangenumbers[0] && ipNumbers[3] < rangenumbers[1]) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        for (int i = 0; i < ipNumbers.Count; i++)
        {
            if (ipNumbers[i] < minIpNumbers[i] || ipNumbers[i] > maxIpNumbers[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool FilterIps(IEnumerable<string> Ips)
    {
        bool result = true;
        foreach (string ip in Ips)
        {
            result = FilterIP(ip);
            if(!result) 
                return false;
        }
        return true;
    }

}
