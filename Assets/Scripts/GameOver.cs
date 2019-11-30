using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : GameOver.cs

* 작성자 : 나선율(김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 플레이어의 체력을 0으로 만든다.

*/


public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {
            other.GetComponent<PlayerHealth>().getDamage(3);
        }
    }
}
