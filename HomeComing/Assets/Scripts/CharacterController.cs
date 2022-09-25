using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator animation;
    [SerializeField] private Transform winSpot;
    private bool go=false;
    private void Update()
    {
        if (go)
        {
            animation.SetBool("isWalking", true);
            rb.velocity = Vector3.forward * moveSpeed;
            if (Mathf.Abs(winSpot.position.z - transform.position.z) < 0.1f)
            {
                rb.velocity = Vector3.zero;
                animation.SetBool("isWin", true);
                Invoke("Loadscene", 2);
            }

            if (transform.position.y < -0.1f)
            {
                animation.SetBool("isFalling", true);
                rb.velocity = Vector3.down * moveSpeed;
                Invoke("Loadscene", 2);
                print("Game Over");
                go = false;
            }
        }
    }
    public void Go()
    {
        go = true;
    }
    public void Loadscene()
    {
        SceneManager.LoadScene("Level1");
    }
}
