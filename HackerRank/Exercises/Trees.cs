using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Trees {

        static Node Insert(Node root, int value) {
            // Given the root of a binary search tree, insert value in the right place
            // Assume no duplicate values
            if (root == null) {
                return new Node(value, null, null);
            }

            if (root.data > value) {
                root.left = Insert(root.left, value);
            } else if (root.data < value) {
                root.right = Insert(root.right, value);
            }

            return root;
        }


        static Dictionary<char, string> morse = new Dictionary<char, string>() {
            {'A', ".-" },
            {'B', "-..." },
            {'C', "-.-." }
        };
        


        static Node c = new Node('C', null, null);
        static Node f = new Node('F', null, null);
        static Node h = new Node('H', null, null);
        static Node j = new Node('J', null, null);
        static Node l = new Node('L', null, null);
        static Node p = new Node('P', null, null);
        static Node q = new Node('Q', null, null);
        static Node v = new Node('V', null, null);
        static Node x = new Node('X', null, null);
        static Node y = new Node('Y', null, null);
        static Node z = new Node('Z', null, null);
        static Node b = new Node('B', null, null);

        static Node s = new Node('S', h, v);
        static Node u = new Node('U', f, null);
        static Node r = new Node('R', l, null);
        static Node w = new Node('W', p, j);
        static Node d = new Node('D', b, x);
        static Node k = new Node('K', c, y);
        static Node g = new Node('G', z, q);
        static Node o = new Node('O', null, null);

        static Node i = new Node('I', s, u);
        static Node a = new Node('A', r, w);
        static Node n = new Node('N', d, k);
        static Node m = new Node('M', g, o);

        static Node e = new Node('E', i, a);
        static Node t = new Node('T', n, m);

        readonly static Node start = new Node(32, e, t); // 32 is space

        public static void MorseToLetters(string word = "-.-. .- -") {
            string[] morseLetters = word.Split(' ');
            foreach (string str in morseLetters) {
                //Console.WriteLine(str);
                Console.Write(GetMorseLetter(str));
            }
        }


        public static char GetMorseLetter(string str) {
            if (string.IsNullOrEmpty(str)) {
                return '?';
            }
            
            Node node = start;

            foreach (char c in str) {
                if (c == '.') {
                    node = node.left;
                } else if (c == '-') {
                    node = node.right;
                } else {
                    return '?';
                }
            }

            return (char)node.data;
            //Console.WriteLine((char)node.data);
        }



        public static void preOrder(Node root) {
            /* 
             Tree traversal, is there a left or a right?

                          1
                           \
                            2
                             \
                              5
                             / \
                            3   6
                             \
                              4

             Morris traversal without recursion or stack
            */

            if (root == null) {
                return;
            }

            Node curr = root;
            Node pre;

            while (curr != null) {
                if (curr.left == null) {
                    Console.WriteLine(curr.data); // In our example the first two have left == null, so we print curr.data and assign curr = right, i.e. 1 and 2
                    curr = curr.right; // When we reach 5, we find this entire block of code will not run because curr.left != null so what goes in else
                } else {
                    pre = curr.left; // Now we use our temp Node and explore the left node
                    while (pre.right != null && pre.right != curr) {
                        pre = pre.right;
                    }
                    if (pre.right == null) {
                        pre.right = curr;
                        Console.WriteLine(curr.data);
                        curr = curr.left;
                    } else {
                        pre.right = null;
                        curr = curr.right;
                    }

                }
            }

        }

        public static void preOrderRecursive(Node root) {
            // The recursive method is easier to understand
            if (root == null) {
                return;
            }

            // If you want operations to be in order, they go before the recursive methods
            // System.out.print(root.data+" ");
            Console.WriteLine(root.data); // Put after the recursives to get reverse order
            
            preOrderRecursive(root.left);
            preOrderRecursive(root.right);

            // Put operations after the recursives if you want them done in reverse order

        }


    }

    public class Node {
        public int data { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int datum, Node l, Node r) {
            data = datum;
            left = l;
            right = r;
        }

        public Node(int datum) {
            data = datum;
        }

        public Node() {

        }
    }
}
