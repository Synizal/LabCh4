using UnityEngine;
using UnityEngine.Video;

public class VideoEvent : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endUI; // UI hiện khi video xong (có thể null)

    void Start()
    {
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video đã chuẩn bị xong");
        vp.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video kết thúc");

        if (endUI != null)
            endUI.SetActive(true);
    }
}
