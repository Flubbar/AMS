/* **********************************************
* 프로그래명 : Test2.cs
• 작성자 : 2018038002 이승연
• 작성일 : 2019.09.19
*프로그램 설명 : 성적계산 프로그램 작성하기
************************************************/
using System;
namespace App
{
    class Student   //Student 클래스를 만들어 개발하시오
    {
        //Attribute (variable) : kor, math, eng
        public double kor;
        public double math;
        public double eng;

        //Method : setScore(), getAverage()
        public void setScore()
        {
            Console.Write("국어성적 : ");
            kor = double.Parse(Console.ReadLine());
            Console.Write("수학성적 : ");
            math = double.Parse(Console.ReadLine());
            Console.Write("영어성적 : ");
            eng = double.Parse(Console.ReadLine());
        }
        public double getAverage()
        {
            return (kor + math + eng) / 3.0;
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            Student kim = new Student();
            kim.setScore();
            Console.WriteLine("과목의 평균은 : = {0}", kim.getAverage());
        }
    }
}