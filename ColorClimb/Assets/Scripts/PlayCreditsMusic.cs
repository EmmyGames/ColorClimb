using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayCreditsMusic : MonoBehaviour
{
    Scene scene;
    int index;
    int creditIndex;
    private void Awake()
    {
        scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;
        creditIndex = scene.buildIndex;
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;

        if(index != creditIndex)
        {
            Destroy(gameObject);
        }
    }
}
