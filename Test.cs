using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MultimapByJohn
{
    class Test
    {
        static public TimeEvaluate te = new TimeEvaluate();
        static void Main(string[] args)
        {
            Multimap<int, int> multimap = new Multimap<int, int>();
            for (int i=1; i<=3; i++)
            {
                for (int j=1; j<=3; j++)
                {
                    multimap.Add(i, j);
                }
            }
            Console.WriteLine(multimap.ToString());
        }
    }
}
