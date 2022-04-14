using System;
delegate double Powers(double x);
namespace MoreAnonymAsResult
{
    internal class Program
    {
        static Powers maker(int n)
        {
            Powers meth;
            meth=delegate (double x)
            {
                double s = 1;
                for (int i = 1; i<=n; i++)
                {
                    s*=x;
                }
                return s;
            };
            return meth;
        }
        static void Main(string[] args)
        {
            Powers sqr = maker(2);
            Powers cube = maker(3);
            for (int i = 1; i<=5; i++)
            {
                Console.WriteLine($"{i,2}:{sqr(i),5}{ cube(i),5}{ maker(4)(i),5}");
        }
        }
    }
}
