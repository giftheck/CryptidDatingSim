using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainTitleButton : MonoBehaviour

{
    public string titleScene;
    public void OnClick()
    {
        SceneManager.LoadScene(titleScene);
    }
}
