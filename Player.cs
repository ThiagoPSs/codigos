using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 100f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Animator animator;

    private int vel;
     void Update()
    {
        vel = 2;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }


    private void FixedUpdate()
    {
        vel = 2;

        if (Input.GetKey(KeyCode.LeftShift)) {
            vel = 5;
        }

        rb.MovePosition(rb.position + movement * vel * Time.fixedDeltaTime);    }
}
