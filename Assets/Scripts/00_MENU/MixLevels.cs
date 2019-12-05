using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

/*

* 프로그램명 : MixLevels.cs

* 작성자 : 이승연 (김민선, 김택원, 나선율, 조수현)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 볼륨의 크기를 조절한다.

*/


public class MixLevels : MonoBehaviour
{
    private void Awake()
    {
        AudioListener.volume = 1.0f;
        Cursor.visible = true;
    }

    public AudioMixer masterMixer;

    public void SetMasterLvl(Slider vol)
    {
        masterMixer.SetFloat("masterVol", vol.value);
    }
    public void SetSfxLvl(float sfxLvl)
    {
        masterMixer.SetFloat("sfxVol", sfxLvl);
    }

    public void SetMusicLvl(float musicLvl)
    {
        masterMixer.SetFloat("musicVol", musicLvl);
    }
    public void SetVocalLvl(float vocalLvl)
    {
        masterMixer.SetFloat("vocalPitch", vocalLvl);
    }
}
