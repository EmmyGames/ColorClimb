using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryProgress : MonoBehaviour
{
    Scene scene;
    int index;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;
    }
    public void DoInteraction()
    {
        SceneManager.LoadScene(index + 1);
    }
}

