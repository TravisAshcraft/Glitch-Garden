using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int delayInSceneLoading = 4;
    int currentSceneIndex;
    public Animator transition;

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

    public void RestartScene()
    {
        StartCoroutine(LoadLevel());
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMainMenu()
    {
        StartCoroutine(LoadLevel());
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }
    public void LoadOptionsMenu()
    {
        StartCoroutine(LoadLevel());
        Time.timeScale = 1;
        SceneManager.LoadScene("Options Menu");
    }


    public void LoadNextScene()
    {
        StartCoroutine(LoadLevel());
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadGame()
    {
        StartCoroutine(LoadLevel());
        SceneManager.LoadScene("Level 1");
    }

    public void LoadYouLose()
    {
        StartCoroutine(LoadLevel());
        SceneManager.LoadScene("Lose Screen");
    }

    public void QuitGame()
    {
        StartCoroutine(LoadLevel());
        Application.Quit();
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(delayInSceneLoading);
    }
}
