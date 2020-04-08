using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    public static class DataStructures {

             
     public class SinglyLinkedListNode {
          public int data;
          public SinglyLinkedListNode next;
     }
     
     
    static void printLinkedList(SinglyLinkedListNode head) {
            Console.WriteLine(head.data);
            if (head.next != null) {
                printLinkedList(head.next);
            }6 
    }


}
}
