using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_script : MonoBehaviour
{
    //From Main Menu UI
    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void TutButton()
    {
        SceneManager.LoadScene("TutorScene");
    }
    public void ExitButton()
    {
        Application.Quit();
    }

    //From Tutorial UI
    public void BackTutButton()
    {
        SceneManager.LoadScene("Main_menu_Scene");
    }

    //From Ending Scene UI
    public void BackEndingButton()
    {
        SceneManager.LoadScene("Main_menu_Scene");
    }
}
