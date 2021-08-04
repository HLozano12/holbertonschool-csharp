using System;

///<summary> Queue class</summary>
class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count;

    ///<summary> Public class Node </summary>
    public class Node 
    {
        private T value = default(T);
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

    ///<summary> Method that creates/adds new node to the end</summary>
    public void Enqueue(T value)
    {
        Node Nnode = new Node(value);

        if (head == null)
        {
            head = Nnode;
        }
        else if (tail == null)
        {
            tail = Nnode;
        }
        else
        {
            tail.next = Nnode;
            tail = Nnode;
        }

        count++;
    }

    ///<summary> returns the count</summary>
    public int Count()
    {
        return count;
    }
}