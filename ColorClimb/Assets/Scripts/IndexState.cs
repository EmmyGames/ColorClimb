using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexState : MonoBehaviour
{
    SceneLoader sl;
    void Start()
    {
        sl = FindObjectOfType<SceneLoader>();
        sl.getMaxIndex();
    }
}
