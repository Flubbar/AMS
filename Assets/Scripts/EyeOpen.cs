using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*

* 프로그램명 : EyeOpen.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 마우스 왼쪽 버튼을 누르고 있으면 앞을 볼 수 있게 한다.

*/


public class EyeOpen : MonoBehaviour
{
    public Timer timer;
    public Image image;
    Color tempColor;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        image = GetComponent<Image>();
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (image.color.a > 0)
            {
                tempColor = image.color;
                tempColor.a -= 0.005f;
                image.color = tempColor;
            }
            else
            {
                tempColor = image.color;
                tempColor.a = 0;
                image.color = tempColor;
            }
        }
        else
        {
            if (image.color.a < 1)
            {
                tempColor = image.color;
                tempColor.a += 0.02f;
                image.color = tempColor;
            }
            else
            {
                tempColor = image.color;
                tempColor.a = 1;
                image.color = tempColor;
            }
        }
        timer.factor = 501 - (int)(image.color.a*500f);
    }
}
