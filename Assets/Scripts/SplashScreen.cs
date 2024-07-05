using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{

    public GameObject splashScreen;
    public GameObject getStartedScreen;
    public GameObject guideScreen;

    void Start()
    {
        StartCoroutine(ShowGetStartedAfterDelay());
    }

    IEnumerator ShowGetStartedAfterDelay()
    {
        yield return new WaitForSeconds(5);
        goToGetStarted();
    }

    public void goToGetStarted()
    {
        splashScreen.SetActive(false);
        getStartedScreen.SetActive(true);
    }

    public void goToGuide()
    {
        getStartedScreen.SetActive(false);
        guideScreen.SetActive(true);
    }

    public void goToHomeScene()
    {
        getStartedScreen.SetActive(false);
        string sceneName = "HomeScene";
        SceneManager.LoadScene(sceneName);
    }


}
