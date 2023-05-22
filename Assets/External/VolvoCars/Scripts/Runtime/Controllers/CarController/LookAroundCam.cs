using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAroundCam : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;
    public float sensitivity = 5f;
    public bool inverseX = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(2) || Input.GetKey(KeyCode.R) || Input.GetKey(KeyCode.C)) {
            rotationY = 0;
            rotationX = 0;
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else {
            // Vector2 mouseDelta;
            // mouseDelta = Mouse.current.delta.ReadValue();
            float invX = 1;
            if (inverseX) invX = -1;
            float delY = invX * Input.GetAxis("Mouse X") * sensitivity;
            if (rotationY + delY <= 100f && rotationY + delY >= -100f) {
                rotationY += delY;
                // transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
            }
            float delX = Input.GetAxis("Mouse Y") * -1 * sensitivity;
            if (rotationX + delX <= 10f && rotationX + delX >= -10f) {
                rotationX += delX;
                // transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
            }
            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
    }
}
