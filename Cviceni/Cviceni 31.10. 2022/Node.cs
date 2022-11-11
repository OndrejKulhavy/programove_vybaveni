class Node
{
    private int value;
    private Node next;

    public int Value
    {
        get { return value; }
        set { this.value = value; }

    }

    public Node Next
    {
        get { return next; }
        set { next = value; }
    }

    public Node(int value, Node next)
    {
        Value = value;
        Next = next;
    }
}