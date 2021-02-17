using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgrammingN
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.solution(3);
        }
    }

    public class Solution
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[,] { { } };

            answer = new int[int.MaxValue, 2];
            Cal(ref answer, new int[n], new int[n], new int[n], n,0);
            
            return answer;
        }

        public void Cal(ref int[,] answer, int[] first,int[] seccond,int[] third,int circleNum,int tries)
        {
            
            if (third.Length == circleNum)
            {
                int[,] answer2 = new int[tries, 2];
                for(int i = 0; i < tries; i++)
                {
                    answer2[i,0] = answer[i,0];
                    answer2[i, 1] = answer[i, 1];
                }
                    
                return;
            }
            else
            {
                Cal()
            }

            return;
        }
    }
}
