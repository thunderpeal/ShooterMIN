using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotareCemeraScript : MonoBehaviour
{
    public bool IsRotareX = true, IsRotareY = true;
    float angle;
    float sense = 5f;
    float angHor, angVer;
    Quaternion originRotation;
    void Start()
    {
        originRotation = transform.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        angHor += Input.GetAxis("Mouse X") * sense;
        angVer += Input.GetAxis("Mouse Y") * sense;
        Quaternion rotationY;
        if (IsRotareY)
        {
            rotationY = Quaternion.AngleAxis(angHor, Vector3.up);
        }
        else
        {
            rotationY = Quaternion.AngleAxis(1, Vector3.up);
        }
        Quaternion rotationX;
        if (IsRotareX)
        {
            rotationX = Quaternion.AngleAxis(-angVer, Vector3.right);
        }
        else
        {
            rotationX = Quaternion.AngleAxis(-1, Vector3.right);
        }

        angVer = Mathf.Clamp(angVer, -60, 60);



        transform.rotation = originRotation * rotationY * rotationX;

    }
}