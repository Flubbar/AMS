using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;// Required when using Event data.

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
