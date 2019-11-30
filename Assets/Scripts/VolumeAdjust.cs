using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

/*

* 프로그램명 : VolumeAdjust.cs

* 작성자 : 이승연 (김민선, 김택원, 나선율, 조수현)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 슬라이더의 값이 볼륨에 적용되도록 한다.

*/


public class VolumeAdjust : MonoBehaviour
{
    public void OnValueChanged(Slider vol)
    {
        AudioListener.volume = vol.value;
    }
}
