using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator animation;
    bool go=false;
    
    void Update()
    {
        if (go)
        {
            animation.SetBool("isWalking", true);
            rb.velocity = Vector3.forward * moveSpeed;
        }
        if (transform.position.y < -0.1f)
        {
            print("Game Over");
        }
    }
    public void Go()
    {
        go = true;
    }
}
