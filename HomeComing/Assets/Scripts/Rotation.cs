using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Rotation : MonoBehaviour
{

    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, 60 * Time.deltaTime);
    }
}
