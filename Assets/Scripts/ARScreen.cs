using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ARScreen : MonoBehaviour
{
    public GameObject ArScreen;
    public GameObject catalogScreen;


    void Start()
    {
        GoToCatalogPage();
    }
    public void GoToCatalogPage()
    {
        catalogScreen.SetActive(true);
    }

    public void goToHomeScene()
    {
        catalogScreen.SetActive(false);
        ArScreen.SetActive(false);
        
        string sceneName = "HomeScene";
        SceneManager.LoadScene(sceneName);
      
    }

}
