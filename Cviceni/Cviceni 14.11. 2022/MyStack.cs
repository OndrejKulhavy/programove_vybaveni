using System;
public class MyStack<T>
{
    private Node<T>? head;

    public MyStack()
    {
        head = null;
    }

    public void Push(T value)
    {
        Node<T> = new Node<T>(value);
        node.Next = head;
        head = node;

    }

    public T Pop()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T value = head.Value;
        head = head.Next;
        return value;
    }

    public T Peek()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return head.Value;
    }

    public bool IsEmpty()
    {
        return head == null;
    }
}