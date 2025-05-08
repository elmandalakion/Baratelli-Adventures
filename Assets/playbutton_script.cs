using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class playbutton_script : MonoBehaviour
{
   public void PlayGame(){
     SceneManager.LoadScene("Level 1");
}

  public void QuitGame(){
   Application.Quit();
}
}
