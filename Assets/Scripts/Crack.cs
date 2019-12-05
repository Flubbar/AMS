using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : Crack.cs

* 작성자 : 조수현 (김민선, 김택원, 나선율, 이승연)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 3-1의 얼음판이 깨지게 한다.

*/


public class Crack : MonoBehaviour
{
    public Collider[] colliders;
    public float Mass = 1;
    public float Drag = 3;
    public AudioSource musicPlayer;
    public AudioClip EffectMusic;
    bool broke = false;

    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
    }

    public static void playSound(AudioClip clip, AudioSource audioPlayer)
    {
        audioPlayer.clip = clip;
        audioPlayer.Play();
    }

    void Awake()
    {
        colliders = gameObject.GetComponentsInChildren<Collider>();
        foreach(Collider item in colliders)
        {
            item.attachedRigidbody.constraints = (RigidbodyConstraints)126;
            item.attachedRigidbody.mass = Mass;
            item.attachedRigidbody.drag = Drag;
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" && broke == false)
        {
            broke = true;
            colliders = gameObject.GetComponentsInChildren<Collider>();
            foreach (Collider item in colliders)
            {
                item.attachedRigidbody.constraints = (RigidbodyConstraints)0;
                playSound(EffectMusic, musicPlayer);
                Destroy(gameObject, 4);
            }
        }
    }
}