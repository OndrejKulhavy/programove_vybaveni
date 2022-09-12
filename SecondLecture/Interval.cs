using System;
public class Interval
{
    private int start;
    private int end;
    public Interval(int start, int end)
    {
        this.start = start;
        this.end = end;
    }

    public int Start
    {
        get { return start; }
        set { start = value; }
    }
    public int End
    {
        get { return end; }
        set { end = value; }
    }

    public Boolean IsIN(int x)
    {
        if (x >= start && x <= end)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Interval Intersection(Interval other)
    {
        bool hasIntersection = false;

        int newStart = 0;
        int newEnd = 0;

        for (int i = other.Start; i < other.End; i++)
        {
            if (!hasIntersection)
            {
                newStart = i;
                hasIntersection = true;
            }
            if (hasIntersection)
            {
                newEnd = i;
            }
        }
        if (hasIntersection)
        {
            return new Interval(newStart, newEnd);
        }
        else
        {
            return null;
        }
    }

}