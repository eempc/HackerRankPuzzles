using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    public static class LinkedList {
        static DoublyLinkedListNode reverse2(DoublyLinkedListNode head) {
            // Switcheroo version
            if (head == null || head.next == null) {
                return head;
            }
            
            DoublyLinkedListNode ptr = head;

            while (ptr != null) {
                // Switch up here
                // Python has a better way to switch:   ptr.prev, ptr.next = ptr.next, ptr.prev
                DoublyLinkedListNode temp = ptr.next;
                ptr.next = ptr.prev;
                ptr.prev = temp;

                head = ptr; // this here makes a new head from the afore-switched one
                ptr = temp; // normally you would do ptr = ptr.next but it was modified, but luckily we made a temp copy of ptr.next before we modified it
            }

            return head;
        }

        static DoublyLinkedListNode reverse(DoublyLinkedListNode head) {
            // This is the same as if it were a singly list
            if (head == null || head.next == null) {
                return head;
            }

            DoublyLinkedListNode top = reverse(head.next);
            head.next.next = head;
            head.next = null;

            return top;
        }


        static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode head) {
            if (head == null || head.next == null) {
                return head;
            }

            SinglyLinkedListNode temp = head;

            while (temp.next != null) {
                if (temp.data == temp.next.data) {
                    temp.next = temp.next.next;
                } else {
                    temp = temp.next;
                }
            }

            return head;
        }

        static int getNode3(SinglyLinkedListNode head, int positionFromTail) {
            // Like getNode2 but made super succinct, note the for loop's second argument is a proper boolean that doesn't involve 'i'      
            SinglyLinkedListNode result = head;

            for (int i = 0; head.next != null; i++) {
                head = head.next; // it alters the list i think
                if (i >= positionFromTail) {
                    result = result.next;
                }
            }

            return result.data;
        }

        static int getNode2(SinglyLinkedListNode head, int positionFromTail) {
            // The race car anology method, both cars "current" and "result" have the same speed but current starts first
            // Second car "result" starts when the index counter here reaches higher than positionFromTail, the reversed index
            int index = 0;

            SinglyLinkedListNode current = head;
            SinglyLinkedListNode result = head;

            while (current != null) {
                current = current.next; // this is how to iterate through a linked list as per normal method, this is the leading race Car "current", if you are looking for a particular value at an index, then you can stop when the index counter has reached it
                
                if (index > positionFromTail) { // this logic here controls when the second car "result" should start
                    result = result.next; // then it will start to iterate through a linked list as per normal but it started late according to position from tail.
                }

                index++; // this goes at the end but it could go into the if statement
            }

            return result.data;
        }

        static int getNode(SinglyLinkedListNode head, int positionFromTail) {
            if (head == null || head.next == null) {
                return head.data;
            }

            int counter = 0;

            List<int> list = new List<int>(); // Dirty list method

            while (head.next != null) {
                list.Add(head.data);
                head = head.next;
                counter++;
            }

            return list[counter-positionFromTail];
        }

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

            public SinglyLinkedListNode() {

            }
        }

        public class DoublyLinkedListNode {
            public int data { get; set; }
            public DoublyLinkedListNode next { get; set; }
            public DoublyLinkedListNode prev { get; set; }

            public DoublyLinkedListNode(int datum) {
                data = datum;
            }
            public DoublyLinkedListNode() {

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
