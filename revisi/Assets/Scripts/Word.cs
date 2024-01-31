using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;

    private int idx;

    private DisplayWord display;
    public Word(string _word, DisplayWord _display)
    {
        word = _word;
        idx = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[idx];
    }

    public void TypeLetter()
    {
        idx++;
        display.RemoveLetter();
    }

    public bool Completed()
    {
        bool hasTyped = (idx >= word.Length);
        if(hasTyped)
        {
            display.RemoveWord();
        }

        return hasTyped;
    }
}
