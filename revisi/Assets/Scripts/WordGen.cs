using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGen : MonoBehaviour
{
    public static string[] kunci = { "Serang", "Rengasdengklok", "Ondel-Ondel", "Juni", "Surabi", "Rusa", "Lumpia", "Semarang", "Sultan", "Gudeg", "Islam", "Pandawa" };
    public static string GetWords()
    {
        int randidx = Random.Range(0, kunci.Length);
        string word = kunci[randidx];

        return word;
    }
}
