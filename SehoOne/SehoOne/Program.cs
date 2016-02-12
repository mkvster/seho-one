using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehoOne
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApp.Start<Startup>(Settings.Instance.BaseUrl);
            Console.ReadLine();
        }
    }
}
