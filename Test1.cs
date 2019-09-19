//2018038002이승연
using System;
namespace App
{
    class Test1
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째 숫자를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("연산자를 입력하세요 (+,-,*,/) : ");
            char op = char.Parse(Console.ReadLine());
            Console.Write("두번째 숫자를 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());

            switch(op)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                    break;
            }
        }
    }
}