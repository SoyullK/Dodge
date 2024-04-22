using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    public float moveSpeed;
    Vector3 input;

    private void Update()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        input.Normalize();
        rb.velocity = input * moveSpeed;
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.localScale = new Vector3(-0.7f, 0.7f, 0.7f);
        }
        else if(Input.GetAxisRaw("Horizontal") > 0 )
        {
            transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }
        if (input != Vector3.zero)
        {
            animator.SetInteger("speed", 1);
        }
    }

}
