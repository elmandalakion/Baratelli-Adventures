using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public string sceneToLoad = "Level 2";
    public GameObject twinkleEffect; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
