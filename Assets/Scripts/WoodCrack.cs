using UnityEngine;
using System.Collections;

/*

* 프로그램명 : WoodCrack

* 작성자 : 조수현 (김민선, 김택원, 나선율, 이승연)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 2-1의 장애물 부서지는 나무판자 위에 올라섰을 때 갈라지게 한다.

*/


public class WoodCrack : MonoBehaviour
{
    public Collider[] colliders;
    public AudioSource source;
    public AudioClip sound;
    public float Mass = 1;
    public float Drag = 2;
    public float time = 1;
    bool broke = false;
    void Awake()
    {
        colliders = gameObject.GetComponentsInChildren<Collider>();
        source = GetComponent<AudioSource>();
        foreach (Collider item in colliders)
        {
            item.attachedRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            item.attachedRigidbody.mass = Mass;
            item.attachedRigidbody.drag = Drag;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                if (time < 0 && broke == false)
                {
                    source.PlayOneShot(sound);
                    colliders = gameObject.GetComponentsInChildren<Collider>();
                    foreach (Collider item in colliders)
                    {
                        item.attachedRigidbody.constraints = RigidbodyConstraints.None;
                        item.attachedRigidbody.AddForceAtPosition(transform.up*-100, transform.position);
                    }
                    broke = true;
                }
            }
        }
    }
}