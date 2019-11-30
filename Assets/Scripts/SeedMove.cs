using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : SeedMove.cs

* 작성자 : 김택원 (김민선, 나선율, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 1-3의 식물이 뱉는 콩알탄의 움직임을 결정한다.

*/


public class SeedMove : MonoBehaviour
{
    AudioSource source;
    public AudioClip damage;
    public float speed = 2.0f;
    bool damaged = false;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && damaged == false)
        {
            damaged = true;
            source.PlayOneShot(damage);
            other.GetComponent<PlayerHealth>().getDamage(1);
            Destroy(gameObject,1);
        }
    }
}
