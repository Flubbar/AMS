using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : StageStart.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 스테이지 처음에 볼륨이 0부터 점점 커지게 한다.

*/


public class StageStart : MonoBehaviour
{
    private void Awake()
    {
        AudioListener.volume = 0f;
    }
    private void RaiseVolume()
    {
        AudioListener.volume += 0.1f;
    }
}
