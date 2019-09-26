/* **********************************************
* 프로그래명 : 실습문제1.cs
* 작성자 : 2018038002 이승연
* 작성일 : 2019.09.26
*프로그램 설명 : 다음과 같은 코드 부분에 SWAP 메소드를 구현하여 값을 치환하는 프로그램을 작성하시오.
************************************************/
using System;

namespace 실습문제1
{
    class Program
    {
        public int temp;
        public void swap(ref int x,ref int y)
        {
            Console.WriteLine("X = {0}, Y = {1}", x, y);
            temp = x;
            x = y;
            y = temp;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Program app = new Program();
            app.swap(ref x, ref y);
            Console.WriteLine("X = {0}, Y = {1}", x, y);
        }
    }
}