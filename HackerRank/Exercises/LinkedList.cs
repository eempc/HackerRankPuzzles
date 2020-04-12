using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    public static class LinkedList {

        static SinglyLinkedListNode ReverseList(SinglyLinkedListNode head) {
            if (head == null | head.next == null) {
                return head;
            }

            SinglyLinkedListNode temp = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return temp;
        }

        static SinglyLinkedListNode DeleteAtIndex(SinglyLinkedListNode head, int position) {
            if (position == 0) {
                return head.next;
            }

            SinglyLinkedListNode ptr = head;

            int index = 1;

            while (position != index && ptr.next != null) {
                ptr = ptr.next;
                index++;
            }

            ptr.next = ptr.next.next;
            // What happens to the deleted node, is it collected?

            return head;
        }

        static SinglyLinkedListNode DeleteAtIndexRecursive(SinglyLinkedListNode head, int position) {
            if (position == 0) {
                return head.next;
            }

            head.next = DeleteAtIndexRecursive(head.next, position - 1);
            return head;
        }

        static SinglyLinkedListNode InsertAtIndex(SinglyLinkedListNode head, int data, int position) {
            if (head == null) {
                return new SinglyLinkedListNode(data);
            }

            // Since we are going to traverse through the linked list we need to start at the head, creating a new object called ptr is a bit safer at this time
            SinglyLinkedListNode ptr = head;

            int index = 1;

            // Traverse through the list O(n) operation to find the right index. Along the way update the ptr to the next object
            while (position != index) {
                ptr = ptr.next;
                index++;
            }

            // Our ptr is now pointing to the correctly indexed node and we now need to insert a new node at this index

            // Inserting the node requires a temp object
            SinglyLinkedListNode tempNode = new SinglyLinkedListNode(data);

            // The temp node needs to point to the ptr's next as we will be next overriding the ptr's next
            tempNode.next = ptr.next;

            // The ptr's next now points to our tempNode
            ptr.next = tempNode;

            // Why would you return the head node? Aside from the question asks for it
            // I get that we are dealing with reference types here
            return head;
        }


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

        static SinglyLinkedListNode InsertAtHead(SinglyLinkedListNode head, int data) {
            if (head == null) {
                return new SinglyLinkedListNode(data);
            }

            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            newNode.next = head;
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
