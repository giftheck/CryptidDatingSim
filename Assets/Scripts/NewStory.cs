using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStory : MonoBehaviour

{
    public string storyName;
    public void OnClick()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(storyName);
    }
}
