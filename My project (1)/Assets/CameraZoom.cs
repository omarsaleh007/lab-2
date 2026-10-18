using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Camera cam;
    public float targetZoom = 5f;
    private float scrollData;
    public float zoomSpeed = 3f;
    void Start()
    {
        cam = GetComponent<Camera>();
        targetZoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        scrollData = Input.GetAxis("Mouse ScrollWheel");
        targetZoom = targetZoom - scrollData;
        targetZoom = Mathf.Clamp(targetZoom, 3f, 7f);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomSpeed);
    }
}
