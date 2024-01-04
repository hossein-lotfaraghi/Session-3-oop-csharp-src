using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // استعاره گرفتن از کلاس و تولید یک شیء جدید از کلاس person
            Person hossein_info = new Person();
            
            
            // تعریف و مقدار دهی به فیلد ها برای یک آبجکت یا یک شیء

            hossein_info.Name = "hossein";
            hossein_info.Family = "araghi";
            hossein_info.Job = "Csharp Developer";
            hossein_info.Sex = "man";

            //خروجی گرفتن

            Console.WriteLine("press any key to even . . . .\n");
            Console.ReadKey();
            Console.WriteLine($"\nyour name is {hossein_info.Name}\nypur family is {hossein_info.Family}\nyour job is {hossein_info.Job}\nyour sex is {hossein_info.Sex}\n");
            Console.ReadKey();
        }
    }
}
