using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;// Required when using Event data.

/*

* 프로그램명 :LoadSoundOnClick.cs

* 작성자 : 이승연 (김민선, 김택원, 나선율, 조수현)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 버튼 클릭시 소리가 재생되도록 한다.

*/


public class LoadSoundOnClick : MonoBehaviour, ISelectHandler
{
    public GameObject audioObject;
    private AudioSource[] vocalAudios;
    public AudioSource selectedButtonAudio;
    public float timeSpan = 0.0f;
    public float checkTime;

    private void Awake()
    {
        vocalAudios = audioObject.GetComponentsInChildren<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnSelect(BaseEventData eventData)
    {
        timeSpan = 0.0f;
        foreach (AudioSource audio in vocalAudios)
            audio.Stop();
        while (timeSpan > checkTime)  // 경과 시간이 특정 시간이 보다 커졋을 경우
        {
            timeSpan += Time.deltaTime;  // 경과 시간을 계속 등록
        }
        selectedButtonAudio.Play();
    }
}
