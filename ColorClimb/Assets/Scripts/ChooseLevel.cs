using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    public SceneLoader sl;
    private void Start()
    {
        sl = FindObjectOfType<SceneLoader>();
    }
    public void ChangeScene(int sceneIndex)
    {
        if (sl.maxIndex >= sceneIndex || sceneIndex < 5)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
