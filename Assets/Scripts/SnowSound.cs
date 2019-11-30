using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : SnowSound.cs

* 작성자 : 김민선(김택원, 나선율, 이승연, 조수현)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 3-3의 장애물 나무위의 쌓인 눈이 소리를 내도록 한다.

*/


public class SnowSound : MonoBehaviour
{

    public AudioSource audio;
    public AudioClip snowBeforeFlump;
    public AudioClip snowFlump;

    public GameObject Snow_;
    public GameObject Player_;
    public Rigidbody rigidbody;
    float forceGravity = 9.8f;

    int i = 0;
    bool trigger = true;

    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.Find("SnowFlump").GetComponent<AudioSource>();
        audio.volume = 1.0f;
        Snow_ = GameObject.Find("SnowOnTree");
        rigidbody = this.GetComponent<Rigidbody>();
        Player_ = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Vector3.Distance(Player_.transform.position, this.transform.position) < 2)
        {
            bool trigger = true;
        }*/
        
        if (audio.isPlaying == false && i == 0/*&&trigger == true*/)
        {
            Debug.Log(" snowBeforeFlump ");
            audio.clip = snowBeforeFlump;
            audio.Play();
            Debug.Log(" i++ ");
            i++;
        }
        if (audio.isPlaying == false && i == 1/*&&trigger == true*/)
        {
            Debug.Log(" snowFlump ");
            audio.clip = snowFlump;
            audio.Play();
            rigidbody.useGravity = true;
            i++;
        }
        if (audio.isPlaying == false && i == 2/*&&trigger == true*/)
        {
        }
    }
}
