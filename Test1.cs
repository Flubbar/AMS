/* **********************************************
* 프로그래명 : Test1.cs
• 작성자 : 2018038002 이승연
• 작성일 : 2019.09.19
*프로그램 설명 : 사용자로부터 입력한 수식을 계산하는 프로그램을 작성하여 보자
************************************************/
using System;
namespace App
{
    class Test1
    {
        static void Main(string[] args)
        {
            //피연산자1(값1) 연산자 피연산자2(값2) 로 구 성되며, 연산자는 *,+,‐,/를 지원함
            //정수형 형변환 int.Parse(Console.ReadLine());
            Console.Write("첫번째 숫자를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("연산자를 입력하세요 (+,-,*,/) : ");
            char op = char.Parse(Console.ReadLine());
            Console.Write("두번째 숫자를 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());

            //switch/case
            switch (op)
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