using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_s_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            for(int i =0; i< s.solution(new int[] { 1, 5, 2, 6, 3, 7, 4 }, new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } }).Length; i++)
            {
                Console.WriteLine(s.solution(new int[] { 1, 5, 2, 6, 3, 7, 4 }, new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } })[i].ToString());
            }
            Console.ReadLine();   
        }
    }

    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.Length/3];
            for (int j = 0; j < commands.Length/3; j++)
            {
                int answerLength = commands[j, 1] - commands[j, 0]+1;

                int[] result = new int[answerLength];
                for (int i = 0; i < answerLength; i++)
                {
                   
                    result[i] = array[i + commands[j, 0]-1];              
                }

                Array.Sort(result);

                answer[j] = result[commands[j, 2]-1];
               
            }
            
            
            return answer;
        }
    }
}
