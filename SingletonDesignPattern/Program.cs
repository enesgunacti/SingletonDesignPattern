using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => 
            {
                var instance = UploadService.Instance(1); 
            });

            Thread t2 = new Thread(() => 
            {
                var instance = UploadService.Instance(2); 
            });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }
    }
}
