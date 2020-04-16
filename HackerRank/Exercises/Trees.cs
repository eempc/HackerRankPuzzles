using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Trees {
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

            Console.WriteLine(root.data);
            preOrderRecursive(root.left);
            preOrderRecursive(root.right);
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
