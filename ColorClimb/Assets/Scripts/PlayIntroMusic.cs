using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayIntroMusic : MonoBehaviour
{
    Scene scene;
    int index;
    private void Awake()
    {
        int introMusicCount = FindObjectsOfType<PlayIntroMusic>().Length;
        if (introMusicCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;
        if (index > 2)
        {
            Destroy(gameObject);
        }
    }
}

