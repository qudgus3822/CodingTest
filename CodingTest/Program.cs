using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] numbers = new int[5] { 1,1,1,1,1};
            Console.WriteLine(s.solution(numbers,3)/2);

            Console.Read();
        }
    }

    public class Solution
    {
        public int solution(int[] numbers, int target)
        {
            int answer = 0;
            int depth = numbers.Length;
            int tempResult = 0;
            int tries = 0;

            Calculator(tries, depth, numbers, ref answer, target, tempResult, true);

            Calculator(tries, depth, numbers, ref answer, target, tempResult,false);



            return answer/2;
        }

        public int Calculator(int tries, int depth, int[] numbers,ref int answer,int target,int current,bool plus)
        {
            if (depth == tries)
            {
                if (target == current)
                {
                    answer++;
                    
                }
                return 0;
            }
            else
            {

                if (plus)
                {
                    current += numbers[tries];
                    Calculator(tries+1, depth, numbers, ref answer, target, current, true);

                    Calculator(tries+1, depth, numbers, ref answer, target, current, false);
                }

                else
                {
                    current -= numbers[tries];
                    Calculator(tries+1, depth, numbers, ref answer, target, current, true);

                    Calculator(tries+1, depth, numbers, ref answer, target, current, false);
                }
            }

            return 0;
        }
    }
}
