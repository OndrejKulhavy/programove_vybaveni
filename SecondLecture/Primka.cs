using System;
public class Primka
{
    private int pointA;
    private int pointB;

    public Primka(int pointA, int pointB)
    {
        if (pointA < pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }
        else
        {
            throw new Exception("pointA must be less than pointB");
        }
    }


    public int PointA
    {
        get { return pointA; }
        set { pointA = value; }
    }

    public int PointB
    {
        get { return pointB; }
        set { pointB = value; }
    }

    public int GetLength()
    {
        return Math.Abs(pointA - pointB);
    }
}