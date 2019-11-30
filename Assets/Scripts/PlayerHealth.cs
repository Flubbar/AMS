using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : PlayerHealth.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 플레이어의 체력을 관리한다.

*/


public class PlayerHealth : MonoBehaviour
{
    public GameManager gameManager;
    public int hp = 3;
    public void getDamage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            gameManager.EndGame();
        }
    }
}
