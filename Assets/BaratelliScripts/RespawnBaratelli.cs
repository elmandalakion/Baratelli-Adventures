using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class RespawnBaratelli : MonoBehaviour
{
    public GameObject messageBox;
    public float respawnDelay = 2.5f;

    private bool isRespawning = false;

    public void TriggerRespawn()
    {
        if (!isRespawning)
        {
            StartCoroutine(HandleRespawn());
        }
    }

    IEnumerator HandleRespawn()
    {
        isRespawning = true;

        // Show the fainting message 🌫️🐸
        messageBox.SetActive(true);

        // Wait for the player to read it 💬⏳
        yield return new WaitForSeconds(respawnDelay);

        // Reload the current scene = full reset 🌟
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
