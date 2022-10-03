public class Potravina
{
    private static double DAILY_INTAKE_KCAL = 2000.0;
    private static double DAILY_INTAKE_KJ = 8700.0;

    private string name;
    private int price;
    private double energy;
    private Jednotky jednotky;
    private int weight;

    public Potravina(string name, int price, Jednotky jednotky, double energy, int weight)
    {
        this.name = name;
        this.price = price;
        this.energy = energy;
        this.weight = weight;
        this.jednotky = jednotky;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Price
    {
        get { return price; }
        set { price = value; }
    }
    public double Energy
    {
        get { return energy; }
        set { energy = value; }
    }
    public Jednotky Jednotky
    {
        get { return jednotky; }
        set { jednotky = value; }
    }
    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }


    public string GetEnergy()
    {
        switch(jednotky)
        {
            case Jednotky.kcal:
                return energy + " kcal";
            case Jednotky.kJ:
                return energy + " kJ";
            default:
                return null;
        }
    }

    public void ChangeJednotky(Jednotky jednotky)   
    {
        if(jednotky != this.jednotky)
        {
            switch(this.jednotky)
            {
                case Jednotky.kcal:
                    energy = energy * 4.1868;
                    break;
                case Jednotky.kJ:
                    energy = energy * 0.239006;
                    break;
            }
        }
    }

    public double GetPercentage()
    {
        if(this.jednotky == Jednotky.kcal)
        {
            return energy / DAILY_INTAKE_KCAL;
        }
        else
        {
            return energy / DAILY_INTAKE_KJ;
        }
    }

    //to string
    
}