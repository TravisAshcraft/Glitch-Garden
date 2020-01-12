using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int delayInSceneLoading = 4;
    int currentSceneIndex;
    

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(SceneLoader());
        }
        

    }

    IEnumerator SceneLoader()
    {
        yield return new WaitForSeconds(delayInSceneLoading);
        LoadNextScene();
        
        
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("Lose Screen");
    }
}
