using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemCtrl : MonoBehaviour
{
    // Use this for initialization
    public float speed = 4;
    public float rotspeed = 100;
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotspeed);
        }
    }
}