using UnityEngine;

public class SnakeAppears : MonoBehaviour
{
    public GameObject snake; 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("uh ohh! Baratelli disturbed the snake! 🐍");
            snake.SetActive(true); 
            
        }
    }
}