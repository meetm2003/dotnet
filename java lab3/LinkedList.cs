using System;

namespace labwork.java_lab3
{
    public class Node
    {
        Node next;
        int data;
        public Node()
        {
            next = null;
            data = 0;
        }
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
        public void append(Node newNode)
        {
            Node t_ref = this;
            while (t_ref.next != null)
            {
                t_ref = t_ref.next;
            }
            Console.WriteLine(newNode.data + " is Appended ");
            t_ref.next = newNode;
            Console.WriteLine();
        }
        public void delete()
        {
            Node t_ref = this;
            while (t_ref.next.next != null)
            {
                t_ref = t_ref.next;
            }

            Console.WriteLine();
            Console.WriteLine(t_ref.next.data + " is Deleted ");
            t_ref.next = null;
        }
        public void traverse()
        {
            Node t_ref = this;
            Console.WriteLine("Linked List : ");
            while (t_ref != null)
            {
                Console.WriteLine(t_ref.data + " ");
                t_ref = t_ref.next;
            }
        }
    }
    public class LinkedList
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Meet Mistry...");
            Node first = new Node(5);
            Node ref1 = new Node(15);
            Node ref2 = new Node(25);
            first.append(ref1);
            first.append(ref2);
            first.traverse();
            first.delete();
            first.traverse();
        }
    }

}
