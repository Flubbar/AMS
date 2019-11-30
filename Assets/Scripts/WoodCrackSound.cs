using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : WoodCrackSound.cs

* 작성자 : 조수현 (김민선, 김택원, 나선율, 이승연)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 갈라지는 나무 판자의 소리를 낸다.

*/


public class WoodCrackSound : MonoBehaviour
{
    public AudioSource musicPlayer;
    public AudioClip EffectMusic;

    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
    }

    public static void playSound_1(AudioClip clip, AudioSource audioPlayer)
    {
        audioPlayer.clip = clip;
        audioPlayer.Play();
    }

    public static void playSound_2(AudioClip clip, AudioSource audioPlayer)
    {
        audioPlayer.clip = clip;
        audioPlayer.Pause();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            playSound_1(EffectMusic, musicPlayer);
    }

    private void OnTriggerExit(Collider other)
    {
        playSound_2(EffectMusic, musicPlayer);
    }
}
