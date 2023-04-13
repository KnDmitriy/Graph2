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
            int v;
            Console.Write("v = ");
            v = int.Parse(Console.ReadLine());
            g.SearchG(v);
            Console.WriteLine();
            Console.WriteLine(g.IsExistEulerPath());
            Console.ReadKey();

        }
    }
}
