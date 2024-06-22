using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
                   
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            var countries = await CountryProvider.Instance.GetCountries();

            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
               
            }
            

            //Another Service

            var countries1 = await CountryProvider.Instance.GetCountries();

            Console.WriteLine(CountryProvider.Instance.CountryCount);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.ReadLine();
        }
    }
}
