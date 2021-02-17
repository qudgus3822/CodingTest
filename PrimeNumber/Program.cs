using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            Console.WriteLine(s.solution(5));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            for(int i = 3; i <= n;i=i+2)
            {
                
                if (PrimeCheck(i))
                {
                    answer++;
                }
            }
            return answer+1;
        }

        private bool PrimeCheck(int i)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;                 
        }
    }
}
