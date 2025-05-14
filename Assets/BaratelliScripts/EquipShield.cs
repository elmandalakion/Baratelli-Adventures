using UnityEngine;

public class EquipShield : MonoBehaviour
{
    public GameObject shield;
    private bool shieldEquipped = false;
    public float spinSpeed = 720f; // degrees per second
    public float spinDuration = 0.3f;

    private bool isSpinning = false;
    private float spinTimeRemaining;
    private Quaternion originalRotation;
    private BaratelliInventory inventory;

    void Start()
    {
        inventory = GetComponent<BaratelliInventory>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Press E to equip/unequip
        {
            EquipOrToggleShield();
        }

        if (isSpinning)
        {
            SpinShield();
        }
    }

    void EquipOrToggleShield()
    {
        shieldEquipped = !shieldEquipped;
        shield.SetActive(shieldEquipped);

        
        inventory.hasShieldEquipped = shieldEquipped;
        inventory.hasSnakeWeapon = shieldEquipped;

        if (shieldEquipped)
        {
            
            originalRotation = shield.transform.localRotation;
            spinTimeRemaining = spinDuration;
            isSpinning = true;

            Debug.Log("Shield equipped! 🛡️✨");
        }
        else
        {
            Debug.Log("Shield unequipped! ❌ No more snake defense!");
        }
    }

    void SpinShield()
    {
        if (spinTimeRemaining > 0f)
        {
            float spinStep = spinSpeed * Time.deltaTime;
            shield.transform.Rotate(Vector3.up, spinStep, Space.Self);
            spinTimeRemaining -= Time.deltaTime;
        }
        else
        {
            
            shield.transform.localRotation = originalRotation;
            isSpinning = false;
        }
    }
}
