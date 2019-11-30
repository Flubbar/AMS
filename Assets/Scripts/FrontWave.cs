using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*

* 프로그램명 : Frontwave.cs

* 작성자 : 김민선(김택원, 나선율, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 스테이지 2-2의 급류 파도의 행동을 결정한다.

*/

public class FrontWave : MonoBehaviour
{
    AudioSource source;
    public AudioClip Splash;
    Vector3 pos;
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        pos = transform.position;
    }

    public void FixedUpdate()
    {
         pos.z += speed;
         transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerHealth>().getDamage(3);
            other.GetComponent<AudioSource>().PlayOneShot(Splash);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().getDamage(3);
            collision.gameObject.GetComponent<AudioSource>().PlayOneShot(Splash);
        }
    }
}