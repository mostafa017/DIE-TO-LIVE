using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{

	public GameObject PauseScreen;
	public static bool paused;
	public KeyCode PauseButton;

	// Use this for initialization
	void Start()
	{
		paused = false;
		PauseScreen.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(PauseButton) && !paused)
		{
			pausee();
		}
		else if (Input.GetKeyDown(PauseButton) && paused)
		{
			Resume();
		}



	}
	void pausee()
	{
		PauseScreen.SetActive(true);
		paused = true;
		Time.timeScale = 0;
	}

	public void Resume()
	{
		PauseScreen.SetActive(false);
		paused = false;
		Time.timeScale = 1;
	}
}
