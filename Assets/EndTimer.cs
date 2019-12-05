using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTimer : MonoBehaviour
{

    GameObject eyelid;
    public GameManager gamemanager;
    Text text;
    string time;
    bool end = false;
    // Start is called before the first frame update
    void Start()
    {
        eyelid = GameObject.Find("Eyelid");
        time = eyelid.GetComponentInChildren<Text>().text;
        Destroy(eyelid);
        text = GetComponent<Text>();
        text.text = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && end == false)
        {
            end = true;
            gamemanager.CompleteLevel();
        }
    }
}
