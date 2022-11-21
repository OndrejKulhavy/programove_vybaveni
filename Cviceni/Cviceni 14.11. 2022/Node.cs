class Node<T>
{
    private T value;
    private Node<T>? next;
    public Node(T value, Node<T>? next)
    {
        Value = value;
        Next = next;
    }
    

    public T Value { get; }
    
    public Node<T>? Next { get; }
}