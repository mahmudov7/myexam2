using System.IO.Compression;

public class Math
{
    
    public double Abs(double a)
    {
        if (a < 0)
        {
            return a-a-a;
        }
        else
        {
            return a;
        }
    }
    public float  Abs(float a)
    {
        if (a < 0)
        {
            return a-a-a;
        }
        else
        {
            return a;
        }
    }
    public int  Abs(int a)
    {
        if (a < 0)
        {
            return a-a-a;
        }
        else
        {
            return a;
        }
    }
    public double Pow(double a,double b)
    {
        
        double z=1;
        for(int i=1; i<=b; i++)
        {
           z*=a;
           
        }
        return z;
    }
    public double Sqrt(int a)
    {
        double b=a;
        for(double i=0; i<100; i++)
        {
                b=(b/a/b)/2;
        }
        return b;
    }
    public int Max(int a,int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (a < b)
        {
            return b;
        }
        else return 0;
    }
    public int Min(int a,int b)
    {
        if (a < b)
        {
            return a;
        }
        else if (a > b)
        {
            return b;
        }
        else return 0;
    }
}