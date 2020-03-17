using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class StacksQueues {

        static int CastleGrid(string[] grid, int startX, int startY, int goalX, int goalY) {
            int count = 0;


            return count;
        }

        public enum Direction {
            Up = 0,
            Down = 1,
            Left = 2,
            Right = 3
        }


        static string BalancedBrackets(string s) {
            if (s.Length % 2 == 1) {
                return "NO";
            }

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
