using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStory : MonoBehaviour

{
    public string storyName;
    public void OnClick()
    {
        SceneManager.LoadScene(storyName);
    }
}
