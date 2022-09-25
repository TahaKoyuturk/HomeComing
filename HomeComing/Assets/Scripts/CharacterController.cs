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
    
    void Update()
    {
        StartCoroutine(CharacterPlay());
    }
    public void Go()
    {
        go = true;
    }
    IEnumerator CharacterPlay()
    {
        while (true)
        {
            if (go)
            {
                animation.SetBool("isWalking", true);
                rb.velocity = Vector3.forward * moveSpeed;
                if (Mathf.Abs(winSpot.position.z - transform.position.z) < 0.1f)
                {
                    rb.velocity = Vector3.zero;
                    animation.SetBool("isWin", true);
                    yield return new WaitForSeconds(1.5f);
                    SceneManager.LoadScene("Level1");
                }
            }
            if (transform.position.y < -0.1f)
            {
                animation.SetBool("isFalling", true);
                rb.velocity = Vector3.down * moveSpeed;
                yield return new WaitForSeconds(2f);
                SceneManager.LoadScene("Level1");
                print("Game Over");
            }
        }
    }
}
