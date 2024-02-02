using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WordManager : MonoBehaviour
{
	public PlayerScript players;
	public List<Word> words;
	public GameObject[] doors;
	public Animator anime;

	public SpawnWord wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;
	private int count = 0;

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
			Debug.Log("done");
			Destroy(doors[count].GetComponent<BoxCollider2D>());
			anime.SetBool("InFrontofDoor", false);
			count++;
            players.walkspeed = 8f;
            hasActiveWord = false;
			words.Remove(activeWord);
		}
	}

}