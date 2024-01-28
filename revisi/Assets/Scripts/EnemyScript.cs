using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float walkspeed = 6f;

    [SerializeField] private Rigidbody2D rb;
    void Update()
    {
        rb.velocity = new Vector2(walkspeed, rb.velocity.y);
        Physics2D.IgnoreLayerCollision(6, 7);
    }

}