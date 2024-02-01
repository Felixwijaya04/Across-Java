using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
	public PlayerScript players;
	public List<Word> words;

	public SpawnWord wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;

    private void Start()
    {
		//AddWord();
		//AddWord();
		//AddWord();
    }

    public void AddWord()
	{
		Word word = new Word(WordGen.GetWords(), wordSpawner.Spawn());
		Debug.Log(word.word);

		words.Add(word);
	}

	public void TypeLetter(char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
			}
		}
		else
		{
			foreach (Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.Completed())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
			players.walkspeed = 8f;

		}
	}

}