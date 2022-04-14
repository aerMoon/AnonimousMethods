using System;
//объявление первого делегата
delegate int Alpha(int n);
//объявление второго делегата
delegate void Bravo(string t);

namespace AnonimousMethods
{

    class MyClass
    {
        public int number;
        public MyClass(int n)
        {
            number = n;
        }
        public Alpha method; //поле класса - ссылка на экз делегата
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объектов
            MyClass obj1 = new MyClass(100);
            MyClass obj2 = new MyClass(200);

            //полю объекта значением присваивается анонимный метод
            obj1.method = delegate (int n)
            {
                return obj1.number + n;
            };

            //полю объекта значением присваивается анонимный метод
            obj2.method = delegate (int n)
            {
                return obj2.number + n;
            };

            int x = 80;

            //вызов экземпляра делегата
            Console.WriteLine($"obj1.method: {obj1.method(x)}");
            Console.WriteLine($"obj2.method: {obj2.method(x)}");

            //объявление переменной типа делегата
            Bravo Show;
            //присваивание переменной анонимного метода:
            Show = delegate (string t)
            {
                Console.WriteLine($"текст: \"{t}\"");
            };

            //вызов экземпляра делегата
            Show("Bravo");

            //присваивание переменной анонимного метода:
            Show = delegate (string t)
            {
                for (int i = 0; i< t.Length; i++)
                {
                    Console.Write($"|{t[i]}");
                }
                Console.WriteLine("|");
            };

            //вызов экземпляра делегата
            Show("Bravo");

        }
    }
}
