﻿using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class ValidParentheses
    {
        public bool IsValid(string s) {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in s) {
                if (ch == '(' || ch == '{' || ch == '[') {
                    stack.Push(ch);
                } else {
                    if (stack.Count == 0) {
                        return false; 
                    }

                    char top = stack.Pop();

              
                    if ((ch == ')' && top != '(') || 
                        (ch == '}' && top != '{') || 
                        (ch == ']' && top != '[')) {
                        return false;
                    }
                }
            }

            return stack.Count == 0; 
        }
    }
}