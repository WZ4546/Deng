using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private BoxCollider2D coll;
    [SerializeField] private int twice = 0;
    [SerializeField] private LayerMask ground;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("horizontal",movement.x);
        animator.SetFloat("speed", movement.sqrMagnitude);
        rb.velocity = new Vector2(movement.x*7f,rb.velocity.y);
        if (Input.GetButtonDown("Jump") && IsGrounded() ) {
            rb.velocity = new Vector2(rb.velocity.x,9f);
            twice = 0;
        }
        else if (Input.GetButtonDown("Jump") && !IsGrounded() && twice == 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 7f);
            twice++;
        }
    }

    private bool IsGrounded() {
        return Physics2D.BoxCast(coll.bounds.center,coll.bounds.size,0f,Vector2.down,.1f, ground);
     }
}
