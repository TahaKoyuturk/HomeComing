using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RotatePlane : MonoBehaviour
{
    bool isRotate = true;
    void Update()
    {
        if(isRotate)
            transform.RotateAround(transform.position, Vector3.up, 60 * Time.deltaTime);
    }
    public void Rotate()
    {
        isRotate = false;
    }
}
