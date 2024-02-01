using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float walkspeed = 8f;
    public float jumpingpower = 6f;
    public float timer = 4;
    private bool hitobstacle = false;
    private string userInput = "";

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
                walkspeed = 8f;
                hitobstacle = false;
            }
        }
        if (Input.anyKeyDown)
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
            walkspeed = 5f;
            hitobstacle = true;
            Debug.Log("hit");
        }
    }

}