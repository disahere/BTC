using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public bool isPaused = false;

    void Start()
    {
        isPaused = false;
    }

    void Update()
    {
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void OnPauseButtonClicked()
    {
        isPaused = true;
    }

    public void OnResumeButtonClicked()
    {
        isPaused = false;
    }
}
