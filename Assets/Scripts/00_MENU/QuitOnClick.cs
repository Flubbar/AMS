using UnityEngine;
using System.Collections;

/*

* 프로그램명 : QuitOnClick.cs

* 작성자 : 이승연 (김민선, 김택원, 나선율, 조수현)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 게임을 종료한다.

*/


public class QuitOnClick : MonoBehaviour
{

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}