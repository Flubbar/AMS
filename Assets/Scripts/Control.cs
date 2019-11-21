using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 speed = new Vector3();

        if (Input.GetKey(KeyCode.LeftArrow))
            speed.x -= 6f;
        if (Input.GetKey(KeyCode.RightArrow))
            speed.x += 6f;
        if (Input.GetKey(KeyCode.UpArrow))
            speed.z += 6f;
        if (Input.GetKey(KeyCode.DownArrow))
            speed.z -= 6f;

        rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, speed, 2f * Time.deltaTime);
    }
}
