using System;
using System.Linq;

namespace UP_Exercise_4
{
    class Math {
        public int Sum(int a, int b) => a + b;
    }
    class Program
    {
        delegate string TimeOfDay();
        delegate int Operation(int a, int b);
        delegate int OperationForClass(int a, int b);
        static string Morning() => "Morning";
        static string Noon() => "Noon";
        static string Evening() => "Evening";
        static string Night() => "Night";
        static int Add(int a, int b) => a + b;
        static int Multiply(int a, int b) => a * b;
        
        static void First()
        {
            int date = Convert.ToInt32(DateTime.Now.Hour);
            TimeOfDay tod = Enumerable.Range(5, 6).Contains(date) ? Morning : Enumerable.Range(11, 6).Contains(date) ? Noon : Enumerable.Range(17, 6).Contains(date) ? Evening : Night;
            Console.WriteLine($"\n{tod()}\n");
        }
        static void Second()
        {
            Console.WriteLine("\nДелегат указывает на метод Add\nOperation del = Add; \nint result = del(4, 5); \nConsole.WriteLine($\"Результат: {result}\"); ");
            Operation del = Add;
            int result = del(4, 5);
            Console.WriteLine($"\nРезультат: {result}\n");
            Console.WriteLine("\nТеперь Делегат указывает на метод Multiply\ndel = Multiply; \nresult = del(4, 5); \nConsole.WriteLine($\"Результат: {result}\"); ");
            del = Multiply;
            result = del(4, 5);
            Console.WriteLine($"\nРезультат: {result}\n");
        }
        static void Third()
        {
            Console.WriteLine("\nДелегату присваивается метод Sum из класса Math\nMath math = new Math();\nOperationForClass delSum = math.Sum;\nint resultSum = delSum(10, 100);\nConsole.WriteLine($\"Результат: {resultSum}\");");
            Math math = new Math();
            OperationForClass delSum = math.Sum;
            int resultSum = delSum(10, 100);
            Console.WriteLine($"\nРезультат: {resultSum}\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Создание делегата и добавление в него методов, в зависимости от времени суток: ");
            First();
            Console.WriteLine("2. Переопределение делегата: ");
            Second();
            Console.WriteLine("3. Присваивание делегату метода из другого класса:");
            Third();
        }
    }
}
