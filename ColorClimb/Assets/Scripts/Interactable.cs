using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] AudioClip[] switchSounds = new AudioClip[2];
    GameObject[] obstacles;
    Renderer[] obstacleRends;
    Collider2D[] obstacleColliders;
    public Sprite switchOn;
    public Sprite switchOff;
    private SpriteRenderer spriteRenderer;
    private int count = 0;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        obstacles = GameObject.FindGameObjectsWithTag(gameObject.tag.Substring(13, gameObject.tag.Length - 13));
        
        obstacleRends = new Renderer[obstacles.Length];
        obstacleColliders = new Collider2D[obstacles.Length];
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacleRends[i] = obstacles[i].GetComponent<Renderer>();
            obstacleColliders[i] = obstacles[i].GetComponent<Collider2D>();
        }
    }
    public void DoInteraction()
    {
        PlaySwitchSound();
        ToggeleSprite();
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacleRends[i].enabled = !obstacleRends[i].enabled;
            obstacleColliders[i].enabled = !obstacleColliders[i].enabled;
        }
    }

    private void PlaySwitchSound()
    {
        AudioClip clip = switchSounds[count % 2];
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
        count++;
    }

    private void ToggeleSprite()
    {
        spriteRenderer.sprite = spriteRenderer.sprite == switchOn ? switchOff : switchOn;
    }
}