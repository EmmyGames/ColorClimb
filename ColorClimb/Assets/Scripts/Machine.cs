using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Machine : MonoBehaviour
{
    public ParticleSystem particle;
    public GameObject player;
    public AudioClip crashSound;
    Scene scene;
    int index;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;
        //play machine humming
    }

    public void DoInteraction()
    {
        player.SetActive(false);
        StartCoroutine(ExecuteAfterTime(1.0f));
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        AudioSource.PlayClipAtPoint(crashSound, Camera.main.transform.position);
        particle.GetComponent<ParticleSystem>().Play();
        time = 6.5f;
        //time = crashSound.length;
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(index + 1);
    }
}
