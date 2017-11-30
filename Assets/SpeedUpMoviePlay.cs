using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Video;

public class SpeedUpMoviePlay : MonoBehaviour
{
    private PlayableDirector playerTimeLine;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            Time.timeScale = 5f;
            GetComponent<VideoPlayer>().playbackSpeed = 5f;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            Time.timeScale = 1f;
            GetComponent<VideoPlayer>().playbackSpeed = 1f;
        }
    }
}