using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

* 프로그램명 : PlayerWalk.cs

* 작성자 : 나선율 (김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 플레이어가 걸을 때 발소리가 나도록 한다.

*/


public class PlayerWalk : MonoBehaviour
{
    public CharacterController controller;
    public AudioSource audioSource;
    public AudioClip grassSound;
    public AudioClip stoneSound;
    public AudioClip woodSound;
    public AudioClip snowSound;
    public AudioClip iceSound;
    public AudioClip waterSound;

    RaycastHit hit;
    bool isPlaying = false;
    float velocity;
    void Awake()
    {
        controller = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
        hit = new RaycastHit();
    }
    IEnumerator Start()
    {
        while (true)
        {
            velocity = controller.velocity.magnitude;
            hit = new RaycastHit();
            string groundTag;
            if (controller.isGrounded == true && velocity > 2f && GetComponent<PlayerHealth>().hp > 0)
            {
                if (Physics.Raycast(transform.position, Vector3.down, out hit))
                {
                    groundTag = hit.collider.gameObject.tag;
                    if (groundTag == "Ground")
                    {
                        audioSource.clip = grassSound;
                        audioSource.pitch = 0.5f + Random.Range(0, 0.3f);
                    }
                    if (groundTag == "Grass")
                    {
                        audioSource.clip = grassSound;
                        audioSource.pitch = 1f + Random.Range(0, 0.3f);
                    }
                    if (groundTag == "Stone")
                    {
                        audioSource.clip = stoneSound;
                        audioSource.pitch = 0.2f + Random.Range(0, 0.3f);
                    }
                    if (groundTag == "Wood")
                    {
                        audioSource.clip = woodSound;
                        audioSource.pitch = 0.5f + Random.Range(0, 0.3f);
                    }
                    if (groundTag == "Snow")
                    {
                        audioSource.clip = snowSound;
                        audioSource.pitch = 1f + Random.Range(0, 0.3f);
                    }
                    if (groundTag == "Ice")
                    {
                        audioSource.clip = iceSound;
                        audioSource.pitch = 1f + Random.Range(0, 0.3f);
                    }
                    if (groundTag == "Water")
                    {
                        audioSource.clip = waterSound;
                        audioSource.pitch = 0.6f + Random.Range(0, 0.5f);
                    }
                }
                audioSource.PlayOneShot(audioSource.clip);
                yield return new WaitForSeconds(0.6f);
            }
            else
            {
                yield return 0;
            }
        }
        
    }
}
