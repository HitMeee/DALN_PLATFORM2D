using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private float moveX = 0f;
    [SerializeField] private float speed = 7f;
    [SerializeField] private float jumpForce = 5f;

    public Rigidbody2D rb;
    [SerializeField] public Animator animator;
    public bool isGrounded;

    public void Init()
    {
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.D)) moveX = 1f;
        else if (Input.GetKey(KeyCode.A)) moveX = -1f;
        else moveX = 0f;

        if (animator != null)
            animator.SetBool("IsRun", moveX != 0f);

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            Jump();
            isGrounded = false;
            if (animator != null)
                animator.SetBool("IsJump", true);
        }

        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        if (moveX > 0f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f); 
        }
        else if (moveX < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f); 
        }

    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}