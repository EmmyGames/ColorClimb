using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    Scene scene;
    public int index;
    public int maxIndex;

    private void Awake()
    {
        int sceneLoaderCount = FindObjectsOfType<SceneLoader>().Length;
        if (sceneLoaderCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey("maxIndex"))
        {
            maxIndex = PlayerPrefs.GetInt("maxIndex");
        }
    }
    public void getMaxIndex()
    {
        scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;
        if (maxIndex < index)
        {
            maxIndex = index;
        }
    }
    void OnDisable()
    {
        PlayerPrefs.SetInt("maxIndex", maxIndex);
    }
}