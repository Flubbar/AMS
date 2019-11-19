using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class MixLevels : MonoBehaviour
{
    public AudioMixer masterMixer;

    public void SetMusicLvl(float musicLvl)
    {
        masterMixer.SetFloat("musicVol", musicLvl);
    }

    public void SetSFXLvl(float sfxLvl)
    {
        masterMixer.SetFloat("sfxVol", sfxLvl);
    }
}
