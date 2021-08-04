﻿using System;

///<summary> Queue class</summary>
class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count;

    ///<summary> Public class Node </summary>
    public class Node 
    {
        public T value = default(T);
        public Node next = null; 

        public Node(T h)
        {
            value = h;
        }
    }
    ///<summary> Returns the first value</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }
    ///<summary> Prints the value</summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        tail = head;
        while(tail != null)
        {
            Console.WriteLine(tail.value);
            tail = tail.next;
        }
    }

    ///<summary> Returns the type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary> Create and adds new node to the end</summary>
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

 ///<summary> Removes new node to the end</summary>
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
    ///<summary> Returns the count</summary>
    public int Count()
    {
        return count;
    }
}