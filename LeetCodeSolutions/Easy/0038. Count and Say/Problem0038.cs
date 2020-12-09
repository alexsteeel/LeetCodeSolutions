using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/problems/count-and-say/
    /// </summary>
    public class Problem0038
    {
        public string CountAndSay(int n)
        {
            var sb = new StringBuilder();

            if (n == 1)
            {
                sb.Append("1");
            }
            else if(n == 2)
            {
                sb.Append("11");
            }
            else
            {
                var temp = CountAndSay(n - 1);

                int count = 1;
                var ln = temp.Length;
                for (int i = 0; i < ln; i++)
                {
                    if (i == ln - 1)
                    {
                        if (temp[i] == temp[i - 1])
                        {
                            sb.Append($"{count}{temp[i]}");
                        }
                        else
                        {
                            sb.Append($"{1}{temp[i]}");
                        }
                    }
                    else if (temp[i] == temp[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        sb.Append($"{count}{temp[i]}");
                        count = 1;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
