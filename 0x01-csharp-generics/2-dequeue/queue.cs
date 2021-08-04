using System;

///<summary>Queue class</summary>
class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count;

    ///<summary> Public class Nodet </summary>
    public class Node 
    {
        public T value = default(T);
        public Node next = null; 

        public Node(T h)
        {
            value = h;
        }
    }

    ///<summary> returns the type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary> create or adds new node to the end of list </summary>
    public void Enqueue(T value)
    {
        Node Nnode = new Node(value);

        if (head == null)
        {
            head = Nnode;
            tail = Nnode;
        }
        else
        {
            tail.next = Nnode;
            tail = Nnode;
        }

        count++;
    }

 ///<summary> Remove new node to the end</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T data = head.value;
        head = head.next;
        count--;
        return data;
    }
    ///<summary> Return the count</summary>
    public int Count()
    {
        return count;
    }
}