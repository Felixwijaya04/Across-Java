using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCode : MonoBehaviour
{
    public EnemyScript enemy;
    public PlayerScript players;
    public WordManager getword;
    private float time = 3;
    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        time = 3;
        Debug.Log("jalan");
        getword.AddWord();
        
        while (time > 0) {
            enemy.walkspeed = 1f;
            time -= Time.deltaTime;
        }

        if (time == 0) enemy.walkspeed = 6f;
    }
}
