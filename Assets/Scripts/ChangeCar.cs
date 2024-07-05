

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeCar : MonoBehaviour
{
    public GameObject catalogScreen;

    public GameObject bmwm3;
    public GameObject bmwm4;


    public void SwitchCarBmwM3()
    {
        catalogScreen.SetActive(false);
        bmwm4.SetActive(false);
        bmwm3.SetActive(true);
    }
    public void SwitchCarBmwM4()
    {
        catalogScreen.SetActive(false);
        bmwm3.SetActive(false);
        bmwm4.SetActive(true);
    }

}
