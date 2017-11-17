using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem pizza = new MenuItem("pizza", "cheese and bread", 2.99);


            Console.WriteLine(pizza.date);
            Console.ReadLine();


        }
    }
}
