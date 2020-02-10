using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnpauseTheGame : MonoBehaviour
{

    public GameObject pauseCanvasUI;
    public GameObject pauseButton;

    void OnClick()
    {
        pauseCanvasUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1.0f;
    }
}
