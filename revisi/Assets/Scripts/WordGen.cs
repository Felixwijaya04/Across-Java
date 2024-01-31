using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGen : MonoBehaviour
{
    public static int count = 0;
    public static string[] kunci = { "Serang", "Rengasdengklok", "Ondel-Ondel", "Juni", "Surabi", "Rusa", "Lumpia", "Semarang", "Sultan", "Gudeg", "Islam", "Pandawa" };
    public static string GetWords()
    {
        string word = kunci[count];
        count += 1;
        return word;
    }

    public static string GetLompat()
    {
        return "lompat";
    }
}
