using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_v_dial : MonoBehaviour
{
    public Dialogue dialogueManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            string[] dialogue = { "Vicky: thank you for evvery thing, kluas hope to see agian ","klaus hope to see you too" };
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
