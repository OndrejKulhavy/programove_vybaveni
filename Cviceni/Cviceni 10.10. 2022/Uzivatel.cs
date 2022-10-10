using System;
class Uzivatel
{
    private string jmeno;
    private string prijmeni;

    private string heslo;

    public string Jmeno
    {
        get { return jmeno; }
        set { jmeno = value; }
    }

    public string Prijmeni
    {
        get { return prijmeni; }
        set { prijmeni = value; }
    }

    public string Heslo
    {
        get { return heslo; }
        set
        {
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(value);
                byte[] hash = sha.ComputeHash(textData);
                heslo = BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
    }

    public Uzivatel(string jmeno, string prijmeni, string heslo)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        Heslo = heslo;
    }

    public override string ToString()
    {
        return "Jmeno: " + Jmeno + " Prijmeni: " + Prijmeni + " Heslo: " + Heslo;
    }
}