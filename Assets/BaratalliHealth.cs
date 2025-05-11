using UnityEngine;
using UnityEngine.UI;

public class BaratelliHealth : MonoBehaviour
{
    public int maxLives = 3;
    public int currentLives;

    public Image[] heartImages; // Drag your heart UI Images here in the Inspector!
    public Sprite fullHeart;
    public Sprite emptyHeart;

    [SerializeField] private Transform respawnPoint; // Drag your respawn point here!

    void Start()
    {
        currentLives = maxLives;
        UpdateHearts();
    }

    public void TakeDamage(int amount)
    {
        currentLives -= amount;
        currentLives = Mathf.Clamp(currentLives, 0, maxLives);
        UpdateHearts();

        if (currentLives <= 0)
        {
            Respawn();
        }
    }

    void UpdateHearts()
    {
        for (int i = 0; i < heartImages.Length; i++)
        {
            if (i < currentLives)
                heartImages[i].sprite = fullHeart;
            else
                heartImages[i].sprite = emptyHeart;
        }
    }

    void Respawn()
    {
        Debug.Log("Baratelli is respawning... 💫🐸");
        currentLives = maxLives;
        transform.position = respawnPoint.position;
        UpdateHearts();
    }
}
