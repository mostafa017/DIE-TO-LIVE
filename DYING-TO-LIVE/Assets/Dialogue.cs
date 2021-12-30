/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour {

	public TextMeshProUGUI textDisplay;
	private string[] dialogueSentences;
	private int index = 0;
	public float typeSpeed;
	public GameObject continueButton;
	public GameObject dialogueBox;
	public Rigidbody2D player;

	// Use this for initialization
	void Start () 
	{
		dialogueBox.SetActive(false);
		continueButton.SetActive(false);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator TypeDialogue()
    {
		dialogueBox.SetActive(true);
		player.constrains = RigidbodyConstrains2D.FreezePositionX | RigidbodyConstrains2D.FreezePositionY;
		foreach (char letter in dialogueSentences[index].ToCharArrary())
        {
			textDisplay.text += letter;

			yield return new WaitForSeconds(typingSpeed);

			if(textDisplay.text == dialogueSentences[index])
            {
				continueButton.SetActive(true);
            }
        }
    }
	public void SetSentences(string[] sentence)
    {
		this.dialogueSentences = sentence;
    }

	public void NextSentence()
    {
		continueButton.SetActive(false);
		if(index < dialogueSentences.Length -1)
        {
			index++;
			textDisplay.text = "";
			StartCoroutine(TypeDialogue());
        }
        else
        {
			textDisplay.text = "";
			continueButton.SetActive(false);
			dialogueBox.SetActive(false);
			this.dialogueSentences = null;
			index = 0;
			player.constrains = RigidbodyContraints2D.None;
			player.constrains = RigidbodyContraints2D.FreezeRotation;
        }
    }
}
*/