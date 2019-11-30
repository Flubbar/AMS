using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*

* 프로그램명 :

* 작성자 : 김택원 (김민선, 나선율, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 오리가 플레이어와 충분히 가까워지면 플레이어를 공격한다.

*/


public class DuckAttack : MonoBehaviour
{
    public AudioSource source;
    public AudioClip damage;
    bool damaged = false;
    float time = 60;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
        source.clip = damage;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time--;
        if (time < 0)
            Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player" && damaged == false)
        {
            damaged = true;
            other.GetComponent<PlayerHealth>().getDamage(1);
            source.PlayOneShot(source.clip);
            Destroy(gameObject, 1);
        }
        
    }
}
