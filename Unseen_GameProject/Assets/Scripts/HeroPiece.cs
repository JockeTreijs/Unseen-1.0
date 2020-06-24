using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPiece : MonoBehaviour
{
    public CameraFollow cameraFollow;

    // Start is called before the first frame update
    void Start()
    {
        cameraFollow = GameObject.Find("MainCamera").GetComponent<CameraFollow>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                cameraFollow.StartCoroutine();
            }
        }
    }
}
