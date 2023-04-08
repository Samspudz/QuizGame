using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public string sceneName;

    void Start()
    {

    }

    void Update()
    {

    }

    public void GoToNewScene()
    {
        GameManager.instance.score = 0;
        SceneManager.LoadScene(sceneName);
    }
}
