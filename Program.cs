using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnnumPOC.Types;

namespace EnnumPOC
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int myNum = (int)Months.april;
            Console.WriteLine(myNum);


            Console.WriteLine("Months");
            foreach (string name in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine(name);
            }
        }
    }
    
}
