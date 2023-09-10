using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class Tour : MonoBehaviour
{

    public VideoClip[] VideosArray = new VideoClip[0];

    private VideoPlayer videoPlayerObject;

 

    void Start()
    {

        videoPlayerObject = gameObject.GetComponent<VideoPlayer>();
        PlayVideo(0);
    }

    public void PlayVideo(int id)
    {
  
        if (id < 0 || id >= VideosArray.Length)
        {
            Debug.LogErrorFormat("Cannot play video number #{0} becouse the array contains {1} video(s)",id, VideosArray.Length);
            return;
        }

        videoPlayerObject.clip = VideosArray[id];

        videoPlayerObject.Play();
    }
}
