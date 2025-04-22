namespace DLL_Sistema_kontrolya_versiy
{
    public class Triangle
    {
        public static double P(double a, double b, double c)
        {
            return (a + b + c)/2;
        }
        public static double S(double a, double b, double c)
        {
            double Pl = (a + b + c)/2;
            return Math.Sqrt(Pl*(Pl - a)*(Pl - b)*(Pl - c));
        }
    }
}
