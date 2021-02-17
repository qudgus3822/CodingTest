using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillLevel1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution("a z Z",3));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public string solution(string s, int n)
        {
            string answer = "";

            
            int A = 65;
            int Z = 90;
            int z = 122;
            int a = 97;

            char[] ss = s.ToCharArray();
            
            for (int i = 0; i < ss.Length; i++)
            {
                if ((ss[i].Equals(' ')))
                {

                    continue;
                }
                int code = Convert.ToInt32(ss[i]);
                int value = Convert.ToInt32(ss[i]) + n;
                if (code < 91)
                {
                    
                    value = Convert.ToInt32(ss[i]) + n;
                    if (value > 90)
                    {
                        value = value - Z;
                        value = value + A - 1;
                    }
                   
                }

                else
                {
                    value = Convert.ToInt32(ss[i]) + n;
                    if (value > 122)
                    {
                        value = value - z;
                        value = value + a - 1;
                    }
                }
                ss[i] = Convert.ToChar(value);               
            }
            String str = new string(ss);
            return str;
        }
    }
}
