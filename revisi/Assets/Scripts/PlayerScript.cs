using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Animator animator;
    public float walkspeed = 7f;
    public float jumpingpower = 3.5f;
    public float timer = 4;
    private bool hitobstacle = false;
    private string userInput = "";

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundlayer;

    private void FixedUpdate()
    {
        animator.SetBool("IsGrounded", isGrounded());
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            animator.SetFloat("IsJumping", rb.velocity.y);
        }
    }

    private void Update()
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
                walkspeed = 6f;
                hitobstacle = false;
            }
        }
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingpower);
            Debug.Log(rb.velocity.y);
        }
    }
   
    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            walkspeed = 4.2f;
            hitobstacle = true;
            Debug.Log("hit");
        }
        
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Lose");
            Destroy(gameObject);
            SceneManager.LoadScene("EndingScene");
            WordGen.wordcount = 0;
        }
    }

}