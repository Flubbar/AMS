using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : WoodDestroy.cs

* 작성자 : 조수현 (김민선, 김택원, 나선율, 이승연)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 나무판자 파편을 없앤다.

*/


public class WoodDestroy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
