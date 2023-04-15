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
            Graph g = new Graph(@"/Users/DmitryKonorov/Projects/Graph2/Graph2/input1.txt");
            int v;
            Console.Write("v = ");
            v = int.Parse(Console.ReadLine());
            g.SearchEulerPath(v);
            Console.WriteLine();
            //Console.WriteLine(g.IsExistEulerPath());
            Console.ReadKey();

        }
    }
}
