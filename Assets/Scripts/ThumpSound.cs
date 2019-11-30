using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : ThumpSound.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 플레이어가 무언가에 부딪혔을 때 소리가 나게 한다.

*/


public class ThumpSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip woodSound;
    public AudioClip stoneSound;
    public AudioClip dirtSound;

    void Start()
    {
        source = GetComponent<AudioSource>();
        if (tag == "Wood")
        {
            source.clip = woodSound;
        }
        if (tag == "Stone")
        {
            source.clip = stoneSound;
        }
        if (tag == "Dirt")
        {
            source.clip = stoneSound;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            source.pitch = Random.Range(0.8f, 1.2f);
            source.PlayOneShot(source.clip);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            source.pitch = Random.Range(0.8f, 1.2f);
            source.PlayOneShot(source.clip);
        }
    }
}
