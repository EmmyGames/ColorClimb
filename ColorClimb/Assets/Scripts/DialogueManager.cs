using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] sentences;
    int i = 0;
    Scene scene;
    int index;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;
    }

   public void StartDialogue(Dialogue dialogue)
    {
        if (dialogue.sentences.Length < i + 1)
        {
            SceneManager.LoadScene(index + 1);
        }
        else
        {
            dialogueText.text = dialogue.sentences[i];
            i++;
        }
    }
}
