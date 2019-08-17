using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses                       //https://leetcode.com/problems/valid-parentheses/
{
    class Solution
    {
        public static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            char[] ValidValues = new char[s.Length];
            int LastElementIndex = s.Length - 1;
            for (int i = 0; i != s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        if (true)
                        {
                            string n = new string(ValidValues);
                            if (n.CompareTo(s) == 0)
                            {
                                return true;
                            }
                        }
                        if (s[LastElementIndex] == ')')
                        {
                            ValidValues[i] = s[i];
                            ValidValues[LastElementIndex] = s[LastElementIndex];
                            LastElementIndex--;
                        }
                        else
                        {
                            ValidValues[i] = s[i];
                        }
                        break;
                    case '{':
                        if (true)
                        {
                            string n = new string(ValidValues);
                            if (n.CompareTo(s) == 0)
                            {
                                return true;
                            }
                        }
                        if (s[LastElementIndex] == '}')
                        {
                            ValidValues[i] = s[i];
                            ValidValues[LastElementIndex] = s[LastElementIndex];
                            LastElementIndex--;
                        }
                        else
                        {
                            ValidValues[i] = s[i];
                        }
                        break;
                    case '[':
                        if (true)
                        {
                            string n = new string(ValidValues);
                            if (n.CompareTo(s) == 0)
                            {
                                return true;
                            }
                        }
                        if (s[LastElementIndex] == ']')
                        {
                            ValidValues[i] = s[i];
                            ValidValues[LastElementIndex] = s[LastElementIndex];
                            LastElementIndex--;
                        }
                        else
                        {
                            ValidValues[i] = s[i];
                        }
                        break;
                    case ')':
                        if (true)
                        {
                            string n = new string(ValidValues);
                            if (n.CompareTo(s) == 0)
                            {
                                return true;
                            }
                        }
                        if (s[i - 1] == '(')
                        {
                            ValidValues[i] = s[i];
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (true)
                        {
                            string n = new string(ValidValues);
                            if (n.CompareTo(s) == 0)
                            {
                                return true;
                            }
                        }
                        if (s[i - 1] == '[')
                        {
                            ValidValues[i] = s[i];
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (true)
                        {
                            string n = new string(ValidValues);
                            if (n.CompareTo(s) == 0)
                            {
                                return true;
                            }
                        }
                        if (s[i - 1] == '{')
                        {
                            ValidValues[i] = s[i];
                        }
                        else
                        {
                            return false;
                        }
                        break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
