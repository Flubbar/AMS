using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : RainSound.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 빗소리를 재생시킨다.

*/


public class RainSound : MonoBehaviour
{
    public AudioSource audioSource;
    public float maxVolume = 0.3f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0;
    }
    void Update()
    {
        if (audioSource.volume < maxVolume)
            audioSource.volume += 0.01f;
    }
}
