using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skillTestVillon.Strategy
{
    public class BubbleSortStrategy : SortStrategy
    {
      
            public string Sort(string input)
            {
                char[] chars = input.ToCharArray();
                for (int i = 0; i < chars.Length - 1; i++)
                {
                    for (int j = 0; j < chars.Length - i - 1; j++)
                    {
                        if (chars[j] > chars[j + 1])
                        {
                            char temp = chars[j];
                            chars[j] = chars[j + 1];
                            chars[j + 1] = temp;
                        }
                    }
                }
                return new string(chars);
            }
        }
    }

