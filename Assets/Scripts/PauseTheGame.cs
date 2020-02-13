using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseTheGame : MonoBehaviour
{

    public GameObject pauseCanvasUI;
    public GameObject pauseButton;

    public void OnClick()
    {
        pauseCanvasUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
}
