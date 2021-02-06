using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;

    private void Awake()
    {
        Screen.SetResolution(567, 1008, false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    private IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        int lastScene = SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(lastScene - 1);
        Destroy(GameObject.Find("Main Music"));
        Cursor.visible = true;
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game Scene");
        FindObjectOfType<GameSession>().ResetGame();
        Cursor.visible = false;
    }

    public void LoadStartMenu()
    {
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
}
