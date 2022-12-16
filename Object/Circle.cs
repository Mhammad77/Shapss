class Circle
{
   public const double pi =3.14;
   public double Radius;
   public double color;
    

    
    public double  GetCircumference()
    {
        double c;
        c = 2*pi*Radius;
        return c;
        
    }
    public double GetAreasr()
    {
        double a;
        a  = pi*Radius*Radius;
        return a;
    }
}