using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CharacterController cc;
    [SerializeField] private RotatePlane rp;
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                cc.Go();
                rp.Rotate();
            }
        }
    }
}
