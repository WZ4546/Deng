using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("horizontal",movement.x);
        animator.SetFloat("speed", movement.sqrMagnitude);
        rb.velocity = new Vector2(movement.x*7f,rb.velocity.y);
        if (Input.GetButtonDown("Jump")) {
            rb.velocity = new Vector2(rb.velocity.x,7f);
        }
    }
}
