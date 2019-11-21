using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack_Sound : MonoBehaviour
{
    public AudioSource musicPlayer;
    public AudioClip EffectMusic;

    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
    }

    public static void playSound(AudioClip clip, AudioSource audioPlayer)
    {
        audioPlayer.clip = clip;
        audioPlayer.Play();
    }

    void OnTriggerStay(Collider col)
    {
        if(col.tag == "Player")
            playSound(EffectMusic, musicPlayer);
    }
}
