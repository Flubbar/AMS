using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*

* 프로그램명 : Timer.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 타이머의 행동을 결정한다.

*/


public class Timer : MonoBehaviour
{
    public int factor = 1;
    Text text;
    int hour, minute, second, milisecond;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string output = null;
        if (time < 359999.99)
            if (factor < 100)
                time += Time.deltaTime * factor;
            else
                time += Time.deltaTime * 100;
        else
            time = 359999.99f;
        hour = (int)(time / 3600);
        minute = (int)(time / 60 % 60);
        second = (int)(time % 60);
        milisecond = (int)(time % 1 * 100);
        if(hour < 10)
            output += '0';
        output += hour.ToString() + ":";
        if (minute < 10)
            output += '0';
        output += minute.ToString() + ":";
        if (second < 10)
            output += '0';
        output += second.ToString() + ".";
        if (milisecond < 10)
            output += '0';
        output += milisecond.ToString();
        text.text = output;
        Color temp = text.color;
        temp.b = (factor - 1) * 0.01f;
        text.color = temp;
    }
}
