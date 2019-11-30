using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : WaterSplash.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 물에 무언가 닿았을 때 첨벙 소리가 나도록 한다.

*/


public class WaterSplash : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip splash;
    public AudioClip bubble;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Wood")
        {
            audioSource = other.GetComponent<AudioSource>();
            audioSource.volume = 0.2f;
            audioSource.pitch = 0.5f + Random.Range(0,1f);
            audioSource.PlayOneShot(splash);
        }
        if (other.tag == "Player")
        {
            audioSource = other.GetComponent<AudioSource>();
            audioSource.pitch = 1.0f;
            audioSource.PlayOneShot(splash);
            audioSource.PlayOneShot(bubble);
        }
    }
}
