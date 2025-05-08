using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuPanel;

    public void PauseGame()
    {
        pauseMenuPanel.SetActive(true); 
        Time.timeScale = 0f;             
    }

    public void ResumeGame()
    {
        pauseMenuPanel.SetActive(false); 
        Time.timeScale = 1f;             
    }

    private void OnDestroy()
    {
        Time.timeScale = 1f;
    }
}
