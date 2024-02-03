using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCode : MonoBehaviour
{
    public Animator anime;
    public EnemyScript enemy;
    public PlayerScript players;
    public WordManager getword;
    private float time = 3;
    public int count = 0;
    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        anime.SetTrigger("InFrontofDoor");
        time = 3;
        Debug.Log("jalan");
        players.walkspeed = 0f;
        if(count == 0)
        {
            getword.AddWord();
            count = 1;
        }
        
        //while (time > 0) {
          //  enemy.walkspeed = 3f;
          //  time -= Time.deltaTime;
        //}

        //if (time == 0) enemy.walkspeed = 6f;
    }
}
