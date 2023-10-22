using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class videoTransition : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += loopPointReached;
    }
    private void loopPointReached(VideoPlayer vp)
    {
        SceneManager.LoadScene("Prefabs 1", LoadSceneMode.Single);
    }
}