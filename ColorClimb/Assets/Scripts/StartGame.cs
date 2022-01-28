﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    Scene scene;
    int index;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(index + 1);
        }
    }
}
