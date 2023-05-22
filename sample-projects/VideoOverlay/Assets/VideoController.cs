using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    [SerializeField] private GameObject videoObject;
    [SerializeField] private GameObject placeholderObject;

    void Awake() {
        VideoPlayer videoPlayer = videoObject.GetComponent<VideoPlayer>();
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "./StreamingAssets/video-overlay.mp4";
        videoPlayer.Prepare();
    }
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer videoPlayer = videoObject.GetComponent<VideoPlayer>();
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        VideoPlayer videoPlayer = videoObject.GetComponent<VideoPlayer>();

        if (videoPlayer.isPlaying && videoPlayer.time > 1) { // 1 second delay
            placeholderObject.SetActive(false);
        } else {
            placeholderObject.SetActive(true);
        }
    }
}
