using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathScene : MonoBehaviour
{
    PlayerStats playerStats;
    private void Start()
    {
        playerStats = FindObjectOfType<PlayerStats>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Reload Scene
        if (playerStats.lives > 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            SceneManager.LoadScene("Death");
        }
        playerStats.Death();
    }
}
