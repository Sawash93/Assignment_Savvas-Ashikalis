using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1); //Game Scene is scene "1"
    }
    public void LoadMainMenu() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Menu");
       
    }
     public void LoadNextScene() 
        {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            Time.timeScale = 1;
            SceneManager.LoadScene(currentSceneIndex + 1);

        }
    

}