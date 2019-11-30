using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Audio;

/*

* 프로그램명 : SelectOnInput.cs

* 작성자 : (김민선, 김택원, 나선율, 이승연, 조수현)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 버튼을 선택하는 커서의 행동을 결정한다.

*/


[RequireComponent(typeof(Selectable))]
public class SelectOnInput : MonoBehaviour, IPointerEnterHandler, IDeselectHandler
{
    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false)
        {
            eventSystem.SetSelectedGameObject(selectedObject);
            buttonSelected = true;
        }
    }

    private void OnDisable()
    {
        buttonSelected = false;
    }

    // 마우스
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!EventSystem.current.alreadySelecting)
            EventSystem.current.SetSelectedGameObject(this.gameObject);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        this.GetComponent<Selectable>().OnPointerExit(null);
    }
}