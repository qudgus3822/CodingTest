using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] a = new int[] { 3,3,1,1,2,2,4,4,5,5,1,1 };

            foreach(var item in s.solution(a))
            {
                Console.WriteLine(item.ToString());
            }
            
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] solution(int[] answers)
        {
            int[] answer = new int[] { };

            int[] A = new int[5] { 1, 2, 3, 4, 5 };
            int[] B = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] C = new int[] { 3,3,1,1,2,2,4,4,5,5};

            int oCountA = 0;
            int oCountB = 0;
            int oCountC = 0;

            for(int i = 0; i < answers.Length; i++)
            {
                //나머지로 하면 될듯? 
                if (answers[i] == A[i % A.Length])
                {
                    oCountA++;
                }
                if(answers[i] == B[i % B.Length])
                {
                    oCountB++;
                }
                if(answers[i] == C[i % C.Length])
                {
                    oCountC++;
                }
            }

            int[] answerCount = new int[3];
            answerCount[0] = oCountA;
            answerCount[1] = oCountB;
            answerCount[2] = oCountC;

            Dictionary<int, int> keys = new Dictionary<int, int>();
            keys.Add(1, oCountA);
            keys.Add(2, oCountB);
            keys.Add(3, oCountC);

            var vkeys = keys.OrderBy(x => x.Value);

            answer = new int[3];

            KeyValuePair<int, int> t2 = new KeyValuePair<int, int>();
            KeyValuePair<int, int> t = new KeyValuePair<int, int>();
            KeyValuePair<int, int> t3 = new KeyValuePair<int, int>();

            int ii = 0;
           foreach(var temp in vkeys)
            {
                if (ii == 0)
                {
                    t = temp;
                }

                else if (ii == 1)
                {
                    t2 = temp;
                }

                else if (ii == 2)
                {
                    t3 = temp;
                }
                ii++;
            }
            if (t3.Value == t2.Value)
            {
                if(t3.Key<t2.Key)
                answer = new int[2] { t3.Key, t2.Key };
                else
                {
                    answer = new int[2] { t2.Key, t3.Key };
                }
            }
            else
            {
                answer = new int[1] { t3.Key };
            }
            if (t3.Value == t2.Value &&t.Value==t3.Value)
            {
                answer = new int[3] { 1, 2, 3 };               
            }

           
            return answer;
        }
    }
}
