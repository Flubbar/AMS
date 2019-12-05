using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : EnemyPlant.cs

* 작성자 : 김택원 (김민선, 나선율, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 스테이지 1-3의 장애물 식물의 행동을 결정한다.

*/


public class EnemyPlant : MonoBehaviour
{
    public float currentDist;
    public float setDist = 5.0f;
    public float coolTime;
    public float setCoolTime = 3.0f;
    public GameObject Seed;
    public Transform AttackPoint;
    public GameObject Player;
    Transform _target;
    private AudioSource plantAudio;
    public AudioClip attackSound;
    bool isSearch = false;



    // Start is called before the first frame update
    void Start()
    {
        plantAudio = GetComponent<AudioSource>();
        _target = Player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isSearch)
        {
            Attack();
        }
        DitectingPlayer();
    }

    private void DitectingPlayer()
    {
        currentDist = Vector3.Distance(transform.position, Player.transform.position);
        if (currentDist < setDist)
        {
            transform.LookAt(_target);
            isSearch = true;
        }
        else
        {
            isSearch = false;
        }
    }
    void Attack()
    {
        coolTime -= 0.1f;
        if (coolTime <= 0)
        {
            plantAudio.PlayOneShot(attackSound);
            Instantiate(Seed, AttackPoint.position, transform.rotation);
            coolTime = setCoolTime;
        }
    }
}