using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._12会员积分
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] old = new int[5];
            for (int i = 0; i < old.Length; i++)
            {
                old[i] = int.Parse(Console.ReadLine());
            }
            int[] newscore = new int[5];
            for (int i = 0; i < newscore.Length; i++)
            {
                newscore[i] = old[i] + 500;
            }
            for (int i = 0; i < newscore.Length; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}",(i+1),old[i],newscore[i]);
            }
        }
    }
}
