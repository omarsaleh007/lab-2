using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed = 6f;
    public float minX = 0f, maxX = 34.8f;
    public float minY = 0f, maxY = 4.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (target != null)
        {
            Vector2 newCamPosition = Vector2.Lerp(transform.position, target.position, Time.deltaTime * cameraSpeed);
            float clampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
            float clampY = Mathf.Clamp(newCamPosition.y, minY, maxY);
            transform.position = new Vector3(clampX, clampY, -10f);
        }
    }
}
