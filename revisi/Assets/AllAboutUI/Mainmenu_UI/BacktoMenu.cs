using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class BacktoMenu : MonoBehaviour
{

    VideoPlayer video;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;


    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("Main_menu_scene");//the scene that you want to load after the video has ended.
    }
}