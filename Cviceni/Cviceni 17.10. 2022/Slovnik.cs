using System;
using System.Collections.Generic;
class Slovnik
{
    private Dictionary<string, List<string>> dictionary;

    public Dictionary<string, List<string>> Dictionary
    {
        get { return dictionary; }
        set { dictionary = value; }
    }

    public Slovnik(Dictionary<string, List<string>> dictionary)
    {
        Dictionary = dictionary;
    }
    
}