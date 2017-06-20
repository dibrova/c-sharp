using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab1_1();
            Console.Clear();
            Lab1_2();
            Console.Clear();
            Lab1_3();
            Console.Clear();
            Lab1_4();
            Console.Clear();
            Lab1_5();
        }

        static void Lab1_1() {
            Console.WriteLine(@"Задание 1. Дано значение температуры T в градусах Фаренгейта. Определить 
значение этой же температуры в градусах Цельсия. Температура по Цельсию
TC и температура по Фаренгейту TF связаны следующим соотношением: 
TC = (TF – 32)*5/9.");
            Console.Write("Ввдите значение температуры в в градусах Фаренгейта F:");
            double TF = double.Parse(Console.ReadLine());
            Console.WriteLine("Температура в градусах Цельсия C: {0:.##}" , (TF - 32) * 5 / 9);
            Console.ReadLine();
            
        }

        static void Lab1_2() {
            Console.WriteLine(@"Задание 2. Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), 
(x3, y3). Найти его периметр и площадь, используя формулу для расстояния 
между двумя точками на плоскости: D=sqrt((x2-x1)^2+(y2-y1)^2). Для нахождения 
площади треугольника со сторонами a, b, c использовать формулу Герона: 
S = (p(p – a)(p – b)(p – c))^(1/2), где p = (a + b + c)/2 — полупериметр.");
            double D1, D2, D3, S, P, p;
            Console.WriteLine("Введите координаты вершин треугольника");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("x3 = ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = double.Parse(Console.ReadLine());
            D1 = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));
            D2 = Math.Sqrt(Math.Pow((x3 - x2), 2.0) + Math.Pow((y3 - y2), 2.0));
            D3 = Math.Sqrt(Math.Pow((x3 - x1), 2.0) + Math.Pow((y3 - y1), 2.0));
            P = D1 + D2 + D3;
            Console.WriteLine("Периметр треугольника : {0:.##}" , P);
            p = P / 2;
            S = Math.Pow((p * (p - D1) * (p - D2) * (p - D3)), 0.5) ;
            Console.WriteLine("Площадь трегольника: " + S);
            Console.ReadLine();

        }

        static void Lab1_3() {
            Console.WriteLine(@"Задание 3. Дано целое число в диапазоне 100–999. Вывести строку-описание 
данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот 
четырнадцать».");
            string[] Digit = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять",
            "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] Digit10 = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] Digit100 = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            int digit;
            do {
                Console.WriteLine("Введите целое число в диапазоне 100–999: ");
                digit = int.Parse(Console.ReadLine());
            } while (digit < 100 || digit > 999 );
            if (digit % 100 < 20) Console.WriteLine(Digit100[digit / 100] + " " + Digit[digit % 100]);
            else Console.WriteLine(Digit100[digit / 100] +" "+ Digit10[digit % 100 / 10] +" "+ Digit[digit % 10]);
            Console.ReadLine();

        }

        static void Lab1_4() {
            Console.WriteLine(@"Задание 4. Даны целые положительные числа A, B, C. Значение этих чисел 
программа должна запрашивать у пользователя. На прямоугольнике размера A * B
размещено максимально возможное количество квадратов со стороной C. Квадраты
не накладываются друг на друга. Найти количество квадратов, размещенных на 
прямоугольнике, а также площадь незанятой части прямоугольника. Необходимо
предусмотреть служебные сообщения в случае, если в прямоугольнике нельзя 
разместить ни одного квадрата со стороной С.");
            int A, B, C;
            do {
                Console.Write("Введите ширину пряммоугольника А: ");
                A = int.Parse(Console.ReadLine());
                Console.Write("Введите высоту прямоугольника В: ");
                B = int.Parse(Console.ReadLine());
                Console.Write("Введите длину стороны квадрата С: ");
                C = int.Parse(Console.ReadLine());
                if (A / C < 1 && B / C < 1) Console.WriteLine("Не возможно разместить квадрат на прямоугольние, измените данные!");
                if (A <= 0 && B <= 0 && C <= 0) Console.WriteLine("Значения должны быть больше 0!");
            } while (A / C < 1 && B / C < 1 && A <= 0 && B <= 0 && C <= 0);

            Console.WriteLine("Колличесто квадратов на рямоугольнике: " + (A / C) * (B / C));
            Console.WriteLine("Свободная площадь на рямоугольнике: " + (A * B - (A / C) * C * (B / C) * C));
            Console.ReadLine();

        }

        static void Lab1_5() {
            Console.WriteLine(@"Задание 5. Начальный вклад в банке равен 1000 руб. Через каждый месяц 
размер вклада увеличивается на P процентов от имеющейся суммы. По данному P 
определить, через сколько месяцев размер вклада превысит 1100 руб., и вывести
найденное количество месяцев K и итоговый размер вклада S.");
            decimal S = 1000,P;
            int K = 0;
            //P = 1.5m;
            Console.Write("Введите на сколько % в месяц увеличивается сумма влада: ");
            P = decimal.Parse(Console.ReadLine());
            do {
                S = S + S / 100 * P;
                K++;
            } while (S < 1100);
            Console.WriteLine("В конце {0} месяца сумма вклада привысит 1100 руб. и составит: {1:.##} руб.", K, S);
            Console.ReadLine();

        }
    }
}
