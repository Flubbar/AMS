//2018038002이승연
using System;
namespace App
{
    class Student
    {
        public double kor;
        public double math;
        public double eng;

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