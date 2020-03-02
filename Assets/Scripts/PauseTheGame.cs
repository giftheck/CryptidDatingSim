using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseTheGame : MonoBehaviour
{
    public GameObject pauseCanvasUI;
    public GameObject mainUICanvas;

    public void OnClick()
    {
        pauseCanvasUI.SetActive(true);
        mainUICanvas.SetActive(false);
        Time.timeScale = 0.0f;
    }
}
