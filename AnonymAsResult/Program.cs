using System;

delegate int MyDelegate();

namespace AnonymAsResult
{
    internal class Program
    {
        //метод возвр ссылку на экз делегата
        static MyDelegate calculate(int n)
        {
            int count = 0;
            //результат через анонимный метод
            return delegate ()
            {
                count+=n;
                return count;
            };
        }
        static void Main(string[] args)
        {
            //экземпляр делегата
            MyDelegate next = calculate(1);
            for (int i = 1; i<=5; i++)
            {
                //вызов экз делегата
                Console.Write(next()+" ");
            }

            Console.WriteLine();
           
            //новое знанчение переменной типа делегата
            next=calculate(3);
            for (int i = 1; i<=5; i++)
            {
                //вызов экз делегата
                Console.Write(next() + " ");
            }
            Console.WriteLine();
        }
    }
}
