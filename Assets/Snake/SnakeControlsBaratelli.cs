using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class SnakeControlsBaratelli : MonoBehaviour
{
    public int maxHearts = 3;
    private int currentHearts;
    
    public Image[] heartIcons;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public Transform respawnPoint;
    public GameObject FaintingText;
    public GameObject Player;

    private bool baratelliInDanger = false;
    private float invincibilityTime = 1.2f;
    private float invincibleTimer = 0f;
    private BaratelliInventory baratelliInventory;


    void Start()
    {
        currentHearts = maxHearts;
        UpdateHeartsUI();
        baratelliInventory = Player.GetComponent<BaratelliInventory>();

    }

void Update()
{
    if (baratelliInDanger && invincibleTimer <= 0f)
    {
       
        if (baratelliInventory != null && !baratelliInventory.hasShieldEquipped)
        {
            HurtBaratelli();
            invincibleTimer = invincibilityTime;
        }
        else
        {
            
            Debug.Log("Shield protected Baratelli! 🛡️🐸");
            gameObject.SetActive(false); 
        }
    }

    if (invincibleTimer > 0f)
    {
        invincibleTimer -= Time.deltaTime;
    }
}


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            baratelliInDanger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            baratelliInDanger = false;
        }
    }

    void HurtBaratelli()
    {
        if (currentHearts > 0)
        {
            currentHearts--;
            Debug.Log("Snake bit Baratelli! 💔 Hearts left: " + currentHearts);
            UpdateHeartsUI();
        }

        if (currentHearts <= 0)
        {
             FaintingText.SetActive(true);

             
             currentHearts=3;
    UpdateHeartsUI();
UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);


        }
    }

    void UpdateHeartsUI()
    {
        for (int i = 0; i < heartIcons.Length; i++)
        {
            if (i < currentHearts)
                heartIcons[i].sprite = fullHeart;
            else
                heartIcons[i].sprite = emptyHeart;
        }
    }
}
