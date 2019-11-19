using System.Collections;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(GameManager.GM.forward))
        {
            transform.position += Vector3.forward / 2;
        }
        if (Input.GetKey(GameManager.GM.backward))
        {
            transform.position += -Vector3.forward / 2;
        }
        if (Input.GetKey(GameManager.GM.left))
        {
            transform.position += Vector3.left / 2;
        }
        if (Input.GetKey(GameManager.GM.right))
        {
            transform.position += Vector3.right / 2;
        }
        if (Input.GetKeyDown(GameManager.GM.jump))
        {
            transform.position += Vector3.up / 2;
        }
    }
}
