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

    public AudioSource source;
    public AudioClip snowBeforeFlump;
    public AudioClip snowFlump;
    public AudioClip damage;
    public int radius = 5;

    public GameObject Snow_;
    public GameObject Player_;
    public Rigidbody rb;
    float forceGravity = 9.8f;

    int i = 0;
    bool trigger = false;
    bool damaged = false;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.volume = 1.0f;
        Snow_ = gameObject;
        rb = this.GetComponent<Rigidbody>();
        Player_ = GameObject.Find("First Person Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(Player_.transform.position, this.transform.position) < radius)
        {
            trigger = true;
        }
        
        if (source.isPlaying == false && i == 0 && trigger == true)
        {
            Debug.Log(" snowBeforeFlump ");
            source.clip = snowBeforeFlump;
            source.Play();
            Debug.Log(" i++ ");
            i++;
        }
        if (source.isPlaying == false && i == 1 && trigger == true )
        {
            Debug.Log(" snowFlump ");
            source.clip = snowFlump;
            source.Play();
            rb.useGravity = true;
            i++;
        }
        if (source.isPlaying == false && i == 2 && trigger == true)
        {
            Destroy(gameObject, 3);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && damaged == false)
        {
            damaged = true;
            source.volume = 0.3f;
            source.pitch = 1.5f;
            source.PlayOneShot(damage);
            other.gameObject.GetComponent<PlayerHealth>().getDamage(1);
        }
    }
}
