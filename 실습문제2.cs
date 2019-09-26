/* **********************************************
* 프로그래명 : 실습문제2.cs
* 작성자 : 2018038002 이승연
* 작성일 : 2019.09.26
*프로그램 설명 : 3명의 학생에 대하여 3과목 (국어, 영어, 수학) 점수를 받아 평균을 계산하고 출력하는 프로그램을 작성하시오.
************************************************/
using System;

namespace 실습문제2
{
    //Student 클래스 생성
    class Student
    {
        public int num = 0; // 0으로 초기화
        public double kor;
        public double math;
        public double eng;

        public void input()
        {
            Console.WriteLine("Student? {0}", num++);

            Console.Write("Korean? ");
            kor = double.Parse(Console.ReadLine());

            Console.Write("Math? ");
            math = double.Parse(Console.ReadLine());

            Console.Write("Eng? ");
            eng = double.Parse(Console.ReadLine());
        }        public double getAverage    // 평균값 얻기
        {
            get { return (kor + math + eng) / 3; }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Student[] sList;        // Student 클래스의 배열 선언
            sList = new Student[3]; // sList 변수에 3개의 메모리 할당
            for (int i = 0; i < 3; i++)
            {
                sList[i] = new Student(); // 개별 sList요소에 Student 클래스 선언
                sList[i].input();   // 성적 입력
            }

            for (int i = 0; i < 3; i++)
                Console.WriteLine("Average = {0:F2}", sList[i].getAverage);
        }
    }
}