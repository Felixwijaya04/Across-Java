using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class WordGen : MonoBehaviour
{
    public static int wordcount = 0;
    public static string[] kunci = { "Serang", "Rengasdengklok", "Ondel-Ondel", "Juni", "Surabi", "Rusa", "Lumpia", "Semarang", "Sultan", "Gudeg", "Islam", "Pandawa" };
    public static string GetWords()
    {
        string word = kunci[wordcount];
        wordcount += 1;
        return word;
    }

    public static string GetLompat()
    {
        return "lompat";
    }
}
