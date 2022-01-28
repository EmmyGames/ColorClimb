using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI livesText;
    public int lives = 3;
    public GameObject bolt, bolt2, bolt3;
    public SceneLoader sl;
    public int currentIndex;

    private void Awake()
    {
        int playerStatCount = FindObjectsOfType<PlayerStats>().Length;
        if(playerStatCount > 1)
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
        sl = FindObjectOfType<SceneLoader>();
        currentIndex = sl.index;
    }
    private void Update()
    {
        if (currentIndex != sl.index && sl.index != -1)
        {
            lives = 3;
            bolt3.gameObject.SetActive(true);
            bolt2.gameObject.SetActive(true);
            currentIndex = sl.index;
        }
    }

    public void Death()
    {
        lives--;
        switch (lives)
        {   
            case 2:
                bolt3.gameObject.SetActive(false);
                break;
            case 1:
                bolt2.gameObject.SetActive(false);
                break;
            case 0:
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }
}
