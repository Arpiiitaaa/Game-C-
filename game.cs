using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    public Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        rb.Velocity = new Vector2 (3, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround)

        if (Input.GetMouseButtonDown(0) && onGround)
        {
            rb.velocity = new Vector2(3, rb.Velocity.x, 3);
        }
    }
}
