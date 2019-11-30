using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Increase : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip Rain;

    Vector3 pos;
    Vector3 pos_O;
    float speed = 0.001f;
    float timerup = 0.0f;
    float timerrain = 0.0f;
    float waitingTime = 100000000;
    public bool prerain = false;
    public bool ifrain = false;
    public bool ifflood = false;
    public bool unflood = false;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.gameObject.transform.position;
        pos_O = pos;
        audio = GameObject.Find("Rain").GetComponent<AudioSource>();
        audio.clip = Rain;
        audio.volume = 1.0f;
        audio.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.gameObject.transform.position;

        timerrain = timerrain + speed;
        if (timerrain > waitingTime * waitingTime)//* waitingTime* waitingTime* waitingTime)
        {
            prerain = true;
            timerrain = 0.0f;
        }
        
        if (i == 0&&audio.isPlaying == false && prerain == true)
        {
            ifrain = true;
            audio.Play();
            i++;
            prerain = false;
        }

        timerup = timerup + speed;

        if (timerup > waitingTime)
        {
            if (ifrain == true)
            {
                transform.position = new Vector3(pos.x, pos.y + speed, pos.z);

                if (pos.y >= 1)
                {
                    ifrain = false;
                    ifflood = true;
                }
            }
            timerup = 0.0f;
        }

        if (unflood == true)
        {
            Debug.Log(" unflood ");
            audio.Stop();
            transform.position = pos_O;
            i--;
            ifflood = false;
            unflood = false;
        }

    }
}
