using UnityEngine;
using TMPro; 

public class ReturnedHome : MonoBehaviour
{
    public GameObject victoryScreen; 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            victoryScreen.SetActive(true);
            Time.timeScale = 0f;        
        }
    }
}
