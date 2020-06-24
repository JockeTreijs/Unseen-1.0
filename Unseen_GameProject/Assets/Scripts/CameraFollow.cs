using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private float orthographicSize;
    public bool zoomedIn;
    public Camera myCamera;

    private void Start()
    {
        zoomedIn = true;
    }
    void FixedUpdate()
    {
        if (zoomedIn)
        {
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothPosition;
        }
    }

    public IEnumerator ViewMap()
    {
        zoomedIn = false;
        while (zoomedIn == false)
        {
            transform.position = new Vector3(0, 0, -10);
            myCamera.orthographicSize = 8.0f;
            yield return new WaitForSeconds(5.0f);
            myCamera.orthographicSize = 4.0f;
            zoomedIn = true;
        }  
    }

    public void StartCoroutine()
    {
        StartCoroutine(ViewMap());
    }
}
