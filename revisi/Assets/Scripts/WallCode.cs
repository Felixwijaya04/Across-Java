using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCode : MonoBehaviour
{
    public GameObject Backgrounds;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("aman");
        Destroy(Backgrounds.GetComponent<SpriteRenderer>());
    }
}
