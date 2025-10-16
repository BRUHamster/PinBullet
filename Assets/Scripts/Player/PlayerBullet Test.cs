using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletTest : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        transform.position = new Vector3(0,0,-1);
    }
}
