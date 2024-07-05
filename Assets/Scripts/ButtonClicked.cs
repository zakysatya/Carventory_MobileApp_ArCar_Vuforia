using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicked : MonoBehaviour
{
    public Button buttonToClick;
    public GameObject parentToShow;    // Start is called before the first frame update
    void Start()
    {
        buttonToClick.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        // Change the color of the button
        ColorBlock colors = buttonToClick.colors;
        colors.normalColor = Color.red; // Change the normal color of the button to red
        buttonToClick.colors = colors;

        // Display the parent GameObject
        parentToShow.SetActive(true);
    }
}
