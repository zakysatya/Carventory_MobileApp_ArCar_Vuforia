using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScreen : MonoBehaviour
{
    public GameObject homeScreen;
    public GameObject guideScreen;

    void Start()
    {
        GoToHomeScreen();
    }

    public void GoToHomeScreen()
    {
        if (guideScreen.activeSelf)
            guideScreen.SetActive(false);

        homeScreen.SetActive(true);
    }

    public void GoToGuidePage()
    {
        homeScreen.SetActive(false);
        guideScreen.SetActive(true);
    }

    public void GoToArScene()
    {
        homeScreen.SetActive(false);
        string sceneName = "ARScene";
        SceneManager.LoadScene(sceneName);
    }

}
