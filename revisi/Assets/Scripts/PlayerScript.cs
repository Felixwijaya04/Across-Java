using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Animator animator;
    public float walkspeed = 8f;
    public float jumpingpower = 6f;
    public float timer = 4;
    private bool hitobstacle = false;
    private string userInput = "";

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundlayer;
    private void FixedUpdate()
    {
        animator.SetBool("IsGrounded", isGrounded());
        // animator.SetBool("IsGrounded", isGrounded());
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
        /*if (Input.anyKeyDown)
        {
            // Get the input key
            char inputKey = Input.inputString.Length > 0 ? Input.inputString[0] : '\0';

            // Append the input key to the user input string
            userInput += inputKey;
            if(userInput[0] != 'b' || userInput[1] != 'i' || userInput[2] != 'm' || userInput[3] != 'a')
            {
                userInput = "";
            }
            // Check if the user input matches the desired pause string
            if (userInput.ToLower() == "bima" && isGrounded())
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingpower);
                userInput = "";
            }

        }*/
        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingpower);
            animator.SetFloat("IsJumping", rb.velocity.y);
            Debug.Log(rb.velocity.y);
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