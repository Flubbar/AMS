using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : Crack_Sound.cs

* 작성자 : (김민선, 김택원, 나선율, 이승연)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 얼음판이 깨지는 소리가 나게 한다.

*/


public class Crack_Sound : MonoBehaviour
{
    public AudioSource musicPlayer;
    public AudioClip EffectMusic;

    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
        musicPlayer.clip = EffectMusic;
        musicPlayer.Play();
        musicPlayer.Pause();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            musicPlayer.UnPause();
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            musicPlayer.Pause();
        }
    }
}
