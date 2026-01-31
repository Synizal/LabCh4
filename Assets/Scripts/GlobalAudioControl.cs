using UnityEngine;

public class GlobalAudioControl : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0 : 1;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            AudioListener.pause = isPaused;
        }
    }
}
