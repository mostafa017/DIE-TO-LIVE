using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialoge : MonoBehaviour
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
        string[] dialogue = { "Ektb hena el script", };
        dialogueManager.SetSentences(dialogue);
        dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
    }
}
}
