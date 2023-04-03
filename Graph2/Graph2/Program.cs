using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(@"C:\Users\konorovda\Desktop\File input output\Graph2\input1.txt");
            g.SearchG();

            Console.ReadKey();

        }
    }
}
