using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataSets
{
    class Program
    {
        static void Main(string[] args)
        {
            new VulnerabilityService().GetVulns();
            Console.Read();
        }
    }
}
