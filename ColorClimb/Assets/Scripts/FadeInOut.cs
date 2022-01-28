using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    public float minimum = 0.0f;
    public float maximum = 1f;
    public float duration = 5.0f;

    public bool FadeOnStart;

    public float startTime;
    public SpriteRenderer sprite;

    Color SpriteColor { get { return sprite != null ? sprite.color : Color.white; } }

    private void Start()
    {
        if (FadeOnStart == true)
        {
            float t = (Time.time - startTime) / duration;
            sprite.color = new Color(SpriteColor.r, SpriteColor.g, SpriteColor.b, Mathf.SmoothStep(minimum, maximum, t));
        }
    }

    // Update is called once per frame
    void Update()
    {
        float t = (Time.time - startTime) / duration;
        sprite.color = new Color(SpriteColor.r, SpriteColor.g, SpriteColor.b, Mathf.SmoothStep(minimum, maximum, t));

    }
}
