using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/*

* 프로그램명 : EnemyDuck.cs

* 작성자 : 김택원 (김민선, 나선율, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 스테이지 2-3의 장애물 오리와 3-2의 장애물 펭귄의 행동을 나타낸다.

*/


public class EnemyDuck : MonoBehaviour
{
    public NavMeshAgent nav;
    bool isNear = false;
    public GameObject Player;
    public GameObject DuckAttack;
    public Transform AttackPoint;
    public float TargetDistance = 2.5f;
    public float MaxDelay = 10;
    public float CurrentDelay = 0;
    private AudioSource duckAudio;
    public AudioClip attakSound;
    public float speed = 0.1f;
    public float soundInterval = 300;
    float interval = 250;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        duckAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // nav.SetDestination(Player.transform.position);

        if(isNear)
        {
            Attack();
        }
        else
        {
            Near();
        }
    }
    void Near()
    {
        float distance = Vector3.Distance(Player.transform.position, transform.position);
        interval++;
        if(interval > soundInterval)
        {
            duckAudio.pitch = 0.7f + Random.Range(0,0.2f);
            duckAudio.PlayOneShot(attakSound);
            interval = 0;
        }
        transform.LookAt(Player.transform);
        transform.Translate(Vector3.forward * speed);
        if (distance<=TargetDistance)
        {
            isNear = true;
        }
    }
    void Attack()
    {
        float distance = Vector3.Distance(Player.transform.position, transform.position);
        CurrentDelay -= 0.1f;
        if(CurrentDelay<=0)
        {
            duckAudio.pitch = 1.0f;
            duckAudio.PlayOneShot(attakSound);
            Instantiate (DuckAttack, AttackPoint.position, transform.rotation);
            CurrentDelay = MaxDelay;
        }
        if(distance>TargetDistance)
        {
            isNear = false;
        }

    }

}
