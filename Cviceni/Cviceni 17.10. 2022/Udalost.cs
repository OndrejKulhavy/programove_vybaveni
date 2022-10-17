using System;
class Udalost
{
    private int id;
    private Typ typ;
    private string popis;
    private Uroven uroven;

    public Typ Typ
    {
        get { return typ; }
        set 
        {
            if (value == Typ.ANY)
                throw new ArgumentException("Typ nemuze byt ANY");
            typ = value; 
        }
    }

    public string Popis
    {
        get { return popis; }
        set { popis = value; }
    }

    public Uroven Uroven
    {
        get { return uroven; }
        set
        {
            if (value == Uroven.ANY)
                throw new ArgumentException("Uroven nemuze byt ANY");
            uroven = value;
        }
    }

    public Udalost(Typ typ, string popis, Uroven uroven)
    {
        Typ = typ;
        Popis = popis;
        Uroven = uroven;
        id = new Random().Next(1000);
    }

    public override string ToString()
    {
        return $"Udalost {id}: (Typ: {Typ}, Popis: {Popis}, Uroven: {Uroven})";
    }
}