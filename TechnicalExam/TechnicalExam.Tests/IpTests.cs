using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalExam;

namespace TechnicalExam.Tests;

public class IpTests
{
    [TestCase("192.168.1.141", true)]
    [TestCase("192.168.1.305", false)]
    public void TestIp(string Ip, bool outcome)
    {
        bool sut = Task2IPFiltering.FilterIP(Ip);

        Assert.That(sut, Is.EqualTo(outcome));
    }
    [TestCase("192.168.1.141", "192.168.1.0/200", true)]
    [TestCase("192.168.1.305", "192.168.1.0/200", false)]
    public void TestIp(string Ip,string cidr, bool outcome)
    {
        bool sut = Task2IPFiltering.FilterIP(Ip, cidr);

        Assert.That(sut, Is.EqualTo(outcome));
    }
}
