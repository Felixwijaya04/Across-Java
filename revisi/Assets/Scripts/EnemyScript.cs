using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float walkspeed = 5f;
    protected float jumpingpower = 6f;

    void Update()
    {
        // rb.velocity = new Vector2(walkspeed, rb.velocity.y);
        Physics2D.IgnoreLayerCollision(6, 7);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            Debug.Log("1");
            // rb.velocity = new Vector2(walkspeed, jumpingpower);
        }
    }
}