class Expression
{
    private double a, c, d;
    public Expression(double a, double c, double d)
    {
        if (((a * a) - 1 == 0)||((d / 4) <= 0))
        {
            throw new Exception("Введенi некорректнi данi");
        }
        this.a = a;
        this.c = c;
        this.d = d;
    }
    public double calculate()
    {
        return (2 * c - Math.Log10(d / 4)) / (a * a - 1);
    }
    public double GetA() { return a; }
    public double GetC() { return c; }
    public double GetD() { return d; }
    public void setA(double a) { this.a = a; }
    public void setC(double c) { this.c = c; }
    public void setD(double d) { this.d = d; }
}
class Program
{
    public static void Main(string[]args)
    {
        Expression[] expressions = new Expression[3];
        Console.WriteLine("2 * c - lg(d/4)");
        Console.WriteLine("---------------");
        Console.WriteLine("  a * a - 1");
        Console.WriteLine("");
        for (int i = 0; i<3; i++)
        {
            try
            {
                Console.WriteLine("expressions[" + i + "]");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("d = ");
                double d = double.Parse(Console.ReadLine());
                expressions[i] = new Expression(a,c,d);
                Console.WriteLine(expressions[i].calculate());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }   
    }
}