using UnityEngine;

public class SnakeDie : MonoBehaviour
{
    public GameObject dramaticPoofEffect;

    void OnTriggerEnter(Collider other)
    {
        // Look for BaratelliInventory on the root object
        BaratelliInventory inventory = other.GetComponentInParent<BaratelliInventory>();

        if (other.CompareTag("Player"))
        {
            if (inventory != null && inventory.hasSnakeWeapon)
            {
                Debug.Log("Snake defeated with magical poison! 💥🐍");

                if (dramaticPoofEffect != null)
                {
                    Instantiate(dramaticPoofEffect, transform.position, Quaternion.identity);
                }

                Destroy(gameObject);
            }
            else
            {
                Debug.Log("You don't have the magical snake weapon yet... 🐍😈");
            }
        }
    }
}