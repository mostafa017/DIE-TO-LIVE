/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    public Dialogue dialogueManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            string[] dialogue = { "Jonathan: Thanks for bringing this stuff up, Klaus",
                                  "Klaus: You're welcome, you know, there's nothing hard for me to do in this world",
                                  "Jonathan: I know, but you're basically not here to deliver that stuff",
                                  "Klaus: Really? Why am I here then?",
                                  "Jonathan: You're here to tell you there's new news about your family, but you have to get to a guy named Sam in Austin who'll tell you everything.",
                                  "Klaus: Are you kidding me? My family passed away five years ago?",
                                  "Jonathan: I'll tell you what he told me",
                                  "Klaus: Do you know what would happen to you if you found out that you were lying to me?",
                                  "Jonathan: Calm down, man. When you get there, you'll know everything.",
                                  "Klaus: Well, we'll see." };
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
*/