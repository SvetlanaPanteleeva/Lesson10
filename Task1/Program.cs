using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            int minute_ = Convert.ToInt32(Console.ReadLine());
            int second_ = Convert.ToInt32(Console.ReadLine());
            Corner corner = new Corner(gradus_, minute_, second_);

           double totalRadians = corner.ToRadians();
            Console.WriteLine(totalRadians);
            Console.ReadKey();
        }
    }
}
