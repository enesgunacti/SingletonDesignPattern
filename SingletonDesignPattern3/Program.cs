using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance; 
            Singleton s2 = Singleton.Instance;

            Console.WriteLine(s1 == s2);

            Console.ReadLine();

        }
    }
}
