using System;
public class Trojuhelnik
{
    private int a;
    private int b;
    private int c;

    public Trojuhelnik(int a, int b, int c)
    {
        if(a + b < c)
        {
            throw new Exception("Triangle cannot be created");
        }
        else
        {
            this.a = a;
            this.b = b;
            this.c = c;    
        }
    }

    public bool IsRovnostranny()
    {
        if(a == b || a == c)
        {
        return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsRovnoramenny()
    {
        if(a == b)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsPravouhly()
    {
        if(a * a + b * b == c * c)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}