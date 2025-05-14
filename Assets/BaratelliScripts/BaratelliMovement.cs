using UnityEngine;

public class PleaseMove : MonoBehaviour
{
    public float moveSpeed = 20f;

   
    public float minX = -20.2f;
    public float maxX = 109.9f;
    public float minZ = 1.04f;
    public float maxZ = 14.92f;

    void Update()
    {
        float move_horizontally = Input.GetAxis("Horizontal");
        float move_vertically = Input.GetAxis("Vertical");

        
        Vector3 move = new Vector3(move_horizontally, 0f, move_vertically) * moveSpeed * Time.deltaTime;

        Vector3 targetPosition = transform.position + move;

        targetPosition.x = Mathf.Clamp(targetPosition.x, minX, maxX);
        targetPosition.z = Mathf.Clamp(targetPosition.z, minZ, maxZ);

        transform.position = targetPosition;



    }
}



