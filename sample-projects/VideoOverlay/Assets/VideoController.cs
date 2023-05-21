using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "./StreamingAssets/video-overlay.mp4";
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
