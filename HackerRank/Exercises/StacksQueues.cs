using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class StacksQueues {

        static string BalancedBrackets(string s) {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s) {
                switch (c) {
                    case ']':
                        if (stack.Count > 0 && stack.Peek() == '[') {
                            stack.Pop();
                        } else {
                            return "NO";
                        }
                        break;
                    case '}':
                        if(stack.Count > 0 && stack.Peek() == '{') {
                            stack.Pop();
                        } else {
                            return "NO";
                        }
                        break;
                    case ')':
                        if(stack.Count > 0 && stack.Peek() == '(') {
                            stack.Pop();
                        } else {
                            return "NO";
                        }
                        break;
                    default:
                        stack.Push(c);
                        break;
                }
            }

            return (stack.Count == 0) ? "YES" : "NO";
        }

    }
}
