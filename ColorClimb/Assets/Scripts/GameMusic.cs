using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMusic : MonoBehaviour
{
    Scene scene;
    private void Awake()
    {
        int gameMusicCount = FindObjectsOfType<GameMusic>().Length;
        if (gameMusicCount > 1)
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
        if (scene.name.Substring(0,5) != "Level" && scene.name.Substring(0, 5) != "Intro")
        {
            Destroy(gameObject);
        }
    }
}
