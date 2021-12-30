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
        string[] dialogue = { "Guider: hello klaus ",
            "klaus: Hi, who are you? ", "Guider: I am your guider and I am here to help you to stay alive in this world"
            ,"Klous: how?" , "Guider: you have a special gun that hepls you to kill any enemy you face ","Kluas: good ", "remember to stay on the platform and avoid any spikes to stay alive",
            "Kluas: ok thank you for your advice", "Guider: ok now go and protect your family :)" };
        dialogueManager.SetSentences(dialogue);
        dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
    }
}
}
