using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : RockPiece.cs

* 작성자 : 조수현 (김민선, 김택원, 나선율, 이승연)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 골인 지점인 돌조각의 행동을 결정한다.

*/


public class RockPiece : MonoBehaviour
{
    AudioSource source;
    public AudioClip spacebar;
    public AudioClip goal;
    public float cooldown;
    public float limit = 180f;
    bool finished = false;
    public GameManager gameManager;
    // Update is called once per frame
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && finished == false)
        {
            finished = true;
            gameManager.CompleteLevel();
            source.PlayOneShot(goal);
        }
    }

    void FixedUpdate()
    {
        transform.Rotate(transform.up, 1);
        if (Input.GetKey(KeyCode.Space))
        {
            if(cooldown == 0)
            {
                source.PlayOneShot(spacebar);
                cooldown = limit;
            }
        }
        if(cooldown > 0)
        {
            cooldown--;
        }
    }
}
