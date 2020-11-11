using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace psfive
{
    class Program
    {
        static private List<StoreCooker> cookers = new List<StoreCooker> { new TargetCooker() };

        static void Main(string[] args)
        {
            foreach(var cooker in cookers)
            {
                cooker.Cook();
            }
        }
    }
}
