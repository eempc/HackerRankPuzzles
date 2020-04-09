using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    public static class DataStructures {

        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data) {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            SinglyLinkedListNode tempNode = head;

            if (head == null) {
                head = newNode;
            } else {
                while (tempNode.next != null) {
                    tempNode = tempNode.next;
                }

                tempNode.next = newNode; // undertsanding reference types and how you modify this
            }
            return head;
        }

        static SinglyLinkedListNode InsertAtHead(SinglyLinkedListNode llist, int data) {
            if (llist == null) {
                return new SinglyLinkedListNode(data);
            }

            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            newNode.next = llist;
            return newNode;
        }

        public class SinglyLinkedListNode {
            public int data { get; set; }
            public SinglyLinkedListNode next { get; set; }

            public SinglyLinkedListNode(int datum) {
                data = datum;
            }
        }


        static void printLinkedList(SinglyLinkedListNode head) {
            Console.WriteLine(head.data);
            if (head.next != null) {
                printLinkedList(head.next);
            }
            // If you want the list printed in reverse, put writeline after the if statement
        }


    }
}
