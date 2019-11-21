using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack : MonoBehaviour
{
    public Collider[] colliders;
    public float Mass = 1;
    public float Drag = 3;
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

    void Awake()
    {
        colliders = gameObject.GetComponentsInChildren<Collider>();
        foreach(Collider item in colliders)
        {
            item.attachedRigidbody.constraints = (RigidbodyConstraints)126;
            item.attachedRigidbody.mass = Mass;
            item.attachedRigidbody.drag = Drag;
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            colliders = gameObject.GetComponentsInChildren<Collider>();
            foreach (Collider item in colliders)
            {
                item.attachedRigidbody.constraints = (RigidbodyConstraints)0;
                playSound(EffectMusic, musicPlayer);
                Destroy(gameObject, 2);
            }
        }
    }
}