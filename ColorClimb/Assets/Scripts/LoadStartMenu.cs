using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStartMenu : MonoBehaviour
{
    Scene scene;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;
        StartCoroutine(ExecuteAfterTime(12.0f)); //make this like 12.0f
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(index + 1);
        }
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(index + 1);
    }
}
