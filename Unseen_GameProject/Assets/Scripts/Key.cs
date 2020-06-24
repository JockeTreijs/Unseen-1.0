using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool gotKey;
    public GameObject invisiblePlatform;
    public GameObject canvas;


    // Start is called before the first frame update
    void Start()
    {
        invisiblePlatform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.transform.parent = canvas.transform;
            invisiblePlatform.gameObject.SetActive(true);
            gotKey = true;
        }
    }
}
