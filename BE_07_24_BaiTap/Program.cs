using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_BaiTap
{
    // install Microsoft.Extensions.DependencyInjection
    internal class Program
    {
        static void Main(string[] args)
        {
            var dj =  new BE_07_24_ConsoleApp.DependencyInjection();
            dj.Dependency();
            Console.ReadLine();
        }
    }
}
