using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_look : MonoBehaviour
{
    [SerializeField] private float Sens = 100;
    [SerializeField] Transform playerbody;
    [SerializeField] private float xRotation = 0;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Sens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 45);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerbody.Rotate(Vector3.up * mouseX);
    }
}
