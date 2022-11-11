using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
class MyLinkedList<T>:IMyLinkedList<T>,IEnumerable<T>
{
    class Node<T>
    {
        private T data;
        private Node<T> next;
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public Node(T data, Node<T> next)
        {
            Data = data;
            Next = next;
        }
    }

    #region Implementace rozhrani IMyLinkedList<T> a IEnumerable<T>
    public int count;

    public void AddToEnd(T element)
    {
        
    }
    public void AddToFront(T element)
    {
        Node<T> node = new Node<T>(element);
        node.Next = value;
        head = node;
        count++;
    }
    public T Get(int index)
    {
        throw new NotImplementedException();
    }

    public void InsertAfter(T element, int index)
    {
    
    }
    public void InsertBefor(T element, int index)
    {
    
    }
    public void Remove(int index)
    {

    }
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    #endregion
}