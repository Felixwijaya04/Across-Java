using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWord : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;
    public DisplayWord Spawn()
    {
        GameObject wordobj = Instantiate(wordPrefab, wordCanvas);
        DisplayWord displayWord = wordobj.GetComponent<DisplayWord>();

        return displayWord;
    }
}
