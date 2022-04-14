using System;
// объявление делегата
delegate char MyDelegate(int n);

namespace AnonymMethAsArg
{
    class MyClass
    {
        public char symbol;
        public MyDelegate get; //экз делегата в качестве поля класса
        public MyClass(char s, MyDelegate md)
        {
            symbol=s;
            get=md;
        }
        public void Set(MyDelegate md) //экз делегата в качестве параметра метода
        {
            get=md;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //создание объекта. вторым аргументом является анонимный метод
            MyClass obj = new MyClass('K',              //символьный аргумент
                                       delegate (int n) //анонимный метод
                                       {
                                           return (char)('A' + n);
                                       }
                                       );
            // вызов экземпляра делегата
            Console.WriteLine($"Символ: \'{obj.get(3)}\' ");

            //вызов метода, аргументом которому передан анонимный метод
            obj.Set(
                    delegate (int n)
                    {
                        return (char)(obj.symbol + n);
                    }
                    );

            //вызов экз делегата
            Console.WriteLine($"Символ: \'{obj.get(3)}\'");


        }
    }
}
