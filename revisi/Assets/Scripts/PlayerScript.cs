using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float originalspeed = 8f;
    public float walkspeed = 8f;
    public float jumpingpower = 6f;
    public float timer = 4;
    private bool hitobstacle = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundlayer;

    void Update()
    {
        rb.velocity = new Vector2(walkspeed, rb.velocity.y);
        if (hitobstacle == true)
        {
            if (timer > 0)
            {
                timer = timer - Time.deltaTime;
            }
            else
            {
                timer = 4;
                walkspeed = originalspeed;
                hitobstacle = false;
            }
        }
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            Debug.Log("jump pressed");
            rb.velocity = new Vector2(rb.velocity.x, jumpingpower);
        }
    }
    // is grounded nya masih error
    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            walkspeed -= 1f;
            hitobstacle = true;
            Debug.Log("hit");
        }
    }

}