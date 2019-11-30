using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : Rise.cs

* 작성자 : 김민선 (김택원, 나선율, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 2-2의 강물의 수위를 점점 올리고, 급류를 생성한다.

*/


public class Rise : MonoBehaviour
{
    public FrontWave wave;
    Vector3 pos;
    public float speed = 0.01f;
    bool stop = false;
    private void Start()
    {
        pos = transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(pos.y < 25)
        {
            pos.y += speed;
            transform.position = pos;
        }
        else if(stop == false)
        {
            stop = true;
            wave.gameObject.SetActive(true);
        }
    }
}
