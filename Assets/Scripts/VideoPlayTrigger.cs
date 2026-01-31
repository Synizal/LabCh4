using UnityEngine;
using UnityEngine.Video;

public class VideoPlayTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            videoPlayer.Play();
        }
    }
}
