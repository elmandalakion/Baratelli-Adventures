using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("A coin was collected!");
            CoinManager.Instance.AddCoin(); // Only this guy counts!
            Destroy(gameObject);
        }
    }
}